using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            pcbZar1.Image = imList.Images[r.Next(1, 6)];
            pcbZar2.Image = imList.Images[r.Next(1, 6)];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pcbZar1.Image = imList.Images[0];
            pcbZar2.Image = imList.Images[0];
        }
    }
}
