using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace AppForm
{
    public partial class KtraSoNguyenTo : Form
    {
        int n;
        public KtraSoNguyenTo()
        {
            InitializeComponent();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool SNTo(int n)
        {
            bool SNT = true;
            if(n == 0)
                SNT = false;
            else if (n < 2)
                SNT = true;
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        SNT = false;
                        break;
                    }
                }
            }
            if (SNT) return true;
            else return false;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            int tong = 0;
            n = Convert.ToInt32(SoNCcB.Text);
            List<int> list = new List<int>();
            string text = "";

            SNTo(n);
            if (SNTo(n))
                KtraTxt.Text = n + " là số nguyên tố";
            else KtraTxt.Text = n + " không phải là số nguyên tố";

            for (int i = 1; i < n; i++)
            {
                if (SNTo(i))
                    list.Add(i);
            }
            foreach (int i in list)
            {
                text += i + " ";
            }
            SNhonNTxt.Text = text;
            SoSNTnhoNTxt.Text = list.Count.ToString();

            foreach (int i in list)
            {
                tong += i;
            }
            TongSNTTxt.Text = tong.ToString();


        }

        private void SoNCcB_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void KtraSoNguyenTo_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 50; i++)
            {
                SoNCcB.Items.Add(i.ToString());
            }
           

        }
    }
}
