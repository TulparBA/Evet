using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evet6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value <= 5)
                sesSeviye.Text = "Ses Seviyesi Çok Düşük";
            else if (trackBar1.Value <= 10)
                sesSeviye.Text = "Ses Seviyesi Normal";
            else
                sesSeviye.Text = "Ses Seviyesi Çok Yüksek";
        }
    }
}
