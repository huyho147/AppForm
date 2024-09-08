using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForm
{
    public partial class StopWatch : Form
    {
        public StopWatch()
        {
            InitializeComponent();
        }
        private DateTime startTime;

        private void Clock_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeSpan = DateTime.Now - startTime;
            label1.Text = timeSpan.ToString(@"hh\:mm\:ss\:ff");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = "00:00:00:00";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
