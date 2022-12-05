using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saniye = 0;
        private void btnBasla_Click(object sender, EventArgs e)
        {
            saniye = Convert.ToInt32(lblKalan.Text);
            lblKalan.Text=txtSure.ToString();
            saniye =Convert.ToInt32(txtSure.Text);
            if(cmbHiz.SelectedIndex == Convert.ToInt32(null))
            {
                MessageBox.Show("Hız Seçmediniz");
            }
            else
            {
                timer1.Interval = System.Convert.ToInt32(cmbHiz.Text);
            }
            timer1.Start();

            // Timer kontrolünü çalıştırır.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                saniye = saniye - 1;
                lblKalan.Text = saniye.ToString();
                if (saniye == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Süre doldu");
                }
            }

        }

        private void btnDur_Click(object sender, EventArgs e)
        {
            listKrono.Items.Add("Kronometre Durdu: " + DateTime.Now.TimeOfDay.ToString());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            listKrono.Items.Clear();
        }
    }
}
