using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // progressBar1.Value += 1;
            progressBar1.PerformStep();
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer.Stop();
                MessageBox.Show("Downloading completed");
            }


            toolStripProgressBar1.PerformStep();
            if (toolStripProgressBar1.Value >= toolStripProgressBar1.Maximum)
            {
                timer.Stop();
                MessageBox.Show("Downloading completed");
            }
        }

        Timer timer = new Timer();

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            var item = toolStripComboBox1.SelectedItem as string;
            if (item == "1.Start")
            {
                timer.Start();
            }
        }

        private void gREENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.SpringGreen;
        }

        private void rEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor=Color.Red;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text=numericUpDown1.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //label1.Text=trackBarRed.Value.ToString();

            int red = trackBarRed.Value;
            redLbl.Text = red.ToString();
            int green = trackBarGreen.Value;
            greenLbl.Text = green.ToString();
            int blue= trackBarBlue.Value;
            blueLbl.Text = blue.ToString();

            this.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
