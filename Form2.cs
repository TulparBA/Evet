using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evet2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            listMalzeme.Items.Add(txtMalzeme.Text);
            txtMalzeme.Clear();
            txtMalzeme.Focus();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (listMalzeme.SelectedIndex != -1)
                listMalzeme.Items.RemoveAt(listMalzeme.SelectedIndex);
            else
                MessageBox.Show("Seçim Yapmadınız");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            listMalzeme.Items.Clear();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
