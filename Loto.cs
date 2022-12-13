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
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int[] girilenSayilar = new int[10];
            girilenSayilar[0] = Convert.ToInt32(textBox1.Text);
            girilenSayilar[1] = Convert.ToInt32(textBox2.Text);
            girilenSayilar[2] = Convert.ToInt32(textBox3.Text);
            girilenSayilar[3] = Convert.ToInt32(textBox4.Text);
            girilenSayilar[4] = Convert.ToInt32(textBox5.Text);
            girilenSayilar[5] = Convert.ToInt32(textBox6.Text);
            girilenSayilar[6] = Convert.ToInt32(textBox7.Text);
            girilenSayilar[7] = Convert.ToInt32(textBox8.Text);
            girilenSayilar[8] = Convert.ToInt32(textBox9.Text);
            girilenSayilar[9] = Convert.ToInt32(textBox10.Text);


            int tahmin = 0, sonuc = 0;
            int sayi, i;
            listBox1.Items.Clear();
            for (i = 0; i < 22; i++)
            {
                sayi = r.Next(0,81);
                listBox1.Items.Add(sayi);

                /*if(textBox1==listBox1)*/
            }
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Bu alan boş geçilemez");
            }
            if (textBox2.Text == "")
            {
                errorProvider2.SetError(textBox2, "Bu alan boş geçilemez");
            }
            if (textBox3.Text == "")
            {
                errorProvider3.SetError(textBox3, "Bu alan boş geçilemez");
            }
            if (textBox4.Text == "")
            {
                errorProvider4.SetError(textBox4, "Bu alan boş geçilemez");
            }
            if (textBox5.Text == "")
            {
                errorProvider5.SetError(textBox5, "Bu alan boş geçilemez");
            }
            if (textBox6.Text == "")
            {
                errorProvider6.SetError(textBox6, "Bu alan boş geçilemez");
            }
            if (textBox7.Text == "")
            {
                errorProvider7.SetError(textBox7, "Bu alan boş geçilemez");
            }
            if (textBox8.Text == "")
            {
                errorProvider8.SetError(textBox8, "Bu alan boş geçilemez");
            }
            if (textBox9.Text == "")
            {
                errorProvider9.SetError(textBox9, "Bu alan boş geçilemez");
            }
            if (textBox10.Text == "")
            {
                errorProvider10.SetError(textBox10, "Bu alan boş geçilemez");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] girilenSayilar = new int[10];
            girilenSayilar[0] = Convert.ToInt32(textBox1.Text);
            girilenSayilar[1] = Convert.ToInt32(textBox2.Text);
            girilenSayilar[2] = Convert.ToInt32(textBox3.Text);
            girilenSayilar[3] = Convert.ToInt32(textBox4.Text);
            girilenSayilar[4] = Convert.ToInt32(textBox5.Text);
            girilenSayilar[5] = Convert.ToInt32(textBox6.Text);
            girilenSayilar[6] = Convert.ToInt32(textBox7.Text);
            girilenSayilar[7] = Convert.ToInt32(textBox8.Text);
            girilenSayilar[8] = Convert.ToInt32(textBox9.Text);
            girilenSayilar[9] = Convert.ToInt32(textBox10.Text);
            for(int a = 0; a < girilenSayilar.Length; a++)
            {
                listBox2.Items.Add(girilenSayilar[a]);
            }
            

            int i=0,tahmin=0;
            for (i = 0; i < 10; i++)
            {
                foreach (int j in listBox1.Items)
                {
                    if (girilenSayilar[i] == j)
                        tahmin++;
                }
            }
            if (tahmin >= 6 || tahmin == 0)
                label12.Text = "Kazandınız:" + tahmin;
            else if (tahmin < 6 || tahmin == 1)
                label12.Text = "Kazanamadınız:" + tahmin;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            listBox1.ClearSelected();
            listBox2.Items.Clear();

        }
    }
}
