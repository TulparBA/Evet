using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evet4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            listKategori.Items.Add(txtUrun.Text);
            txtUrun.Clear();
            txtUrun.Focus();
        }

        private void txtUrun_TextChanged(object sender, EventArgs e)
        {

        }

        private void listKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            int sayi = listKategori.CheckedItems.Count;
            for(i = 0; i < sayi; i++)
            {
                listBox1.Items.Add(listKategori.CheckedItems[i]);
            }
        }
    }
}
