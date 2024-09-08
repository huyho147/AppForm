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
    public partial class TinhptBac2 : Form
    {
        public TinhptBac2()
        {
            InitializeComponent();
        }
        double SoA, SoB, SoC, x1, x2, delta;
        private void TinhptBac2_Load(object sender, EventArgs e)
        {
            SoATxt.Text = trackBar1.Value.ToString();
            SoBTxt.Text = trackBar2.Value.ToString();
            SoCTxt.Text = trackBar3.Value.ToString();
            SoA = Convert.ToDouble(SoATxt.Text);
            SoB = Convert.ToDouble(SoBTxt.Text);
            SoC = Convert.ToDouble(SoCTxt.Text);

        }

        private void SoATxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            SoATxt.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            SoBTxt.Text = trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            SoCTxt.Text = trackBar3.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoA = Convert.ToDouble(SoATxt.Text);
            SoB = Convert.ToDouble(SoBTxt.Text);
            SoC = Convert.ToDouble(SoCTxt.Text);
            KetQuaLsB.Items.Clear();

            delta = Math.Pow(SoB, 2) - 4 * SoA * SoC;
            if (SoA == 0)
                PTBac1(SoB, SoC);
            else
            {
                if (delta < 0)
                    KetQuaLsB.Items.Add("Phương trình vô nghiệm !!! Delta < 0");
                else if (delta == 0)
                {
                    x1 = -SoB / 2 * SoA;
                    KetQuaLsB.Items.Add("Phương trình có nghiệm kép x = " + x1.ToString());
                }
                else
                {
                    x1 = (-SoB + Math.Sqrt(delta)) / 2 * SoA;
                    x2 = (-SoB - Math.Sqrt(delta)) / 2 * SoA;
                    KetQuaLsB.Items.Add("Phương trình có 2 nghiệm phân biệt !!!" + Environment.NewLine);
                    KetQuaLsB.Items.Add("x1 = " + x1.ToString("0.##") + Environment.NewLine);
                    KetQuaLsB.Items.Add("x2 = " + x2.ToString("0.##"));
                }

            }
        }


        private void PTBac1(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                    KetQuaLsB.Items.Add("Phương trình vô số nghiệm !!!");
                else
                    KetQuaLsB.Items.Add("Phương trình vô nghiệm !!!");
            }
            else
            {
                x1 = -b / a;
                KetQuaLsB.Items.Add("Nghiệm là: " + x1.ToString("0.##"));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
