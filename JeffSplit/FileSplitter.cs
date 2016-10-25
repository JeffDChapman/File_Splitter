using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace JeffSplit
{

    public partial class FileSplitter : Form
    {
        private string inputFileName;
        private string outputPath;
        private long maxChunk = 512 * 1024;
        private int secsElapsed = 0;
        private TimeSpan timeElapsed;

        public FileSplitter()
        {
            InitializeComponent();
            txtMaxChunk.Text = (maxChunk / 1024).ToString() + "K";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tmrSeconds.Enabled = true;
            SplitFile(inputFileName, maxChunk, outputPath);
            this.Close();
        }

        private void SplitFile(string inputFile, long chunkSize, string path)
        {
            this.button1.Enabled = false;
            const int BUFFER_SIZE = 20 * 1024;
            byte[] buffer = new byte[BUFFER_SIZE];

            using (Stream input = File.OpenRead(inputFile))
            {
                int index = 0;
                int smallRemain = BUFFER_SIZE;
                while (input.Position < input.Length)
                {
                    using (Stream output =
                        File.Create(path + "\\" + Path.GetFileName(inputFile) + "." + 
                        index.ToString().PadLeft(4, '0')))
                    {
                        long remaining = chunkSize;
                        int bytesRead;
                        while (remaining > 0 
                            && (bytesRead = input.Read(buffer, 0, smallRemain)) > 0)
                        {
                            output.Write(buffer, 0, bytesRead);
                            remaining -= bytesRead;
                            if (remaining > BUFFER_SIZE)
                                { smallRemain = BUFFER_SIZE;}
                            else
                                { smallRemain = Convert.ToInt32(remaining); }
                            this.pbarSplitPct.Value = Convert.ToInt32(input.Position * 99.9 / input.Length);
                            this.pbarSplitPct.Refresh();
                            Application.DoEvents();
                        }
                    }
                    index++;
                    smallRemain = BUFFER_SIZE;
                    Thread.Sleep(500); // experimental; perhaps try it
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dialGetFile.ShowDialog();
            inputFileName = this.dialGetFile.FileName;
            this.dialGetFile.Dispose();
            this.lblFileSelected.Text = Path.GetFileName(inputFileName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dialGetFolder.ShowDialog();
            outputPath = this.dialGetFolder.SelectedPath;
            this.dialGetFolder.Dispose();
            this.lblSelectedPath.Text = outputPath;
            this.button1.Enabled = true;
        }

        private void txtMaxChunk_Leave(object sender, EventArgs e)
        {
            int chkForKloc = this.txtMaxChunk.Text.Length;
            string getCharK = this.txtMaxChunk.Text.Substring(chkForKloc - 1, 1);
            int valueWithLetter = Convert.ToInt32(this.txtMaxChunk.Text.Substring(0, chkForKloc - 1));
            switch (getCharK)
            {
                case "K":
                    maxChunk = Convert.ToInt64(valueWithLetter) * 1024;
                    break;
                case "M":
                    maxChunk = Convert.ToInt64(valueWithLetter) * 1024 * 1024;
                    break;
                case "G":
                    maxChunk = Convert.ToInt64(valueWithLetter) * 1024 * 1024 * 1024;
                    break;
                default:
                    maxChunk = Convert.ToInt64(txtMaxChunk.Text) * 1024;
                    txtMaxChunk.Text += "K";
                    this.txtMaxChunk.Refresh();
                    break;
            }
        }

        private void tmrSeconds_Tick(object sender, EventArgs e)
        {
            secsElapsed += 1;
            timeElapsed = TimeSpan.FromSeconds(secsElapsed);
            this.lblElapsed.Text = String.Format("{0:hh.mm.ss}", timeElapsed.ToString());
            try
            {
                double pctDone = this.pbarSplitPct.Value / 99.9;
                TimeSpan timeLeft = TimeSpan.FromSeconds(timeElapsed.TotalSeconds * (1 - pctDone) / pctDone);
                this.lblRemaining.Text = String.Format("{0:hh.mm.ss}", timeLeft.ToString());
            }
            catch { }

        }
    }
}
