using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void linkHakkinda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int tiklanan;
            tiklanan = linkHakkinda.Links.IndexOf(e.Link);
            //Tıklanan linkin ziyaret edildiği belirtilir
            linkHakkinda.Links[tiklanan].Visited = true;
            // Linki çalıştırmak için ilgili işlem gerçekleştirilir
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkHakkinda.Links.Add(71, 20, "http://bilgi.baskent.edu.tr");
            linkHakkinda.Links.Add(101, 25, "mailto:muhammed@baskent.edu.tr");
        }
    }
}
