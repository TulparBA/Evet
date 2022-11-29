using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Evet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            puanHesap();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            puanHesap();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            puanHesap();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            puanHesap();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            puanHesap();
        }

        public void puanHesap() 
        {
             int puan = 0;

            puan = Convert.ToInt32(puanLB.Text);
            if (radioButton1.Checked)
                puan=5;
            if (radioButton2.Checked)
                puan=4;
            if (radioButton3.Checked)
                puan=3;
            if (radioButton4.Checked)
                puan = 2;
            if (radioButton5.Checked)
                puan = 1;
            puanLB.Text = Convert.ToString(puan);
        }
    }
}
