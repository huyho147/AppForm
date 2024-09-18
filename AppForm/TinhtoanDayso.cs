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
    public partial class TinhtoanDayso : Form
    {
        public TinhtoanDayso()
        {
            InitializeComponent();
        }
        List<int> list = new List<int>();
        int so;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            string kq = "";
            list.Add(Convert.ToInt32(SoTxt.Text));
            SoTxt.Text = "";
            foreach (int i in list)
            {
                kq += (i + " ").ToString();
                DaySoTxt.Text = kq;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SochanTxt.Text = "";
            foreach (int i in list)
            {
                if (i % 2 == 0)
                    SochanTxt.Text += (" " + i + " ").ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach (int i in list)
            {
                tong += i;
            }
            TongTxt.Text = tong.ToString();
        }

        private bool SNT(int n)
        {
            if (n < 2)
                return false;
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                        return false;
                }
            }

            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SntTxt.Text = "";
            foreach (int i in list)
            {
                if (SNT(i))
                {
                    SntTxt.Text += (" " + i + " ").ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.Sort();
            foreach (int i in list)
            {
                SapxepTangTxt.Text += (" " + i + " ").ToString();
            }
        }

        private void SapxepTxt_TextChanged(object sender, EventArgs e)
        {

        }
        int DoiXsangY(int x, int y)
        {
            return y.CompareTo(x);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            list.Sort(DoiXsangY);
            foreach (int i in list)
            {
                SapxepGiamTxt.Text += (" " + i + " ").ToString();
            }
        }
    }
}
