using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Play
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can solve your .net problems,Go Http://www.msdotnet.co.in/ ,Read and implement each concepts ");

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = openFileDialog2.FileName;

        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.pause();
        }

        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.play();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.stop();
        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.previous();
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.next();
        }

        private void fastForwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.fastForward();
        }

        private void fastReverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.fastReverse();
        }
    }
}