using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evet5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            nSaat.Enabled = false;
            nDakika.Enabled = false;
            button1.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int alarmSaat=Convert.ToInt32(nSaat.Value);
            int alarmDakika = Convert.ToInt32(nDakika.Value);
            int alarmGun=Convert.ToInt32(nGun.Value);
            int alarmAy = Convert.ToInt32(nAy.Value);
            int alarmYil=Convert.ToInt32(nYil.Value);
            int simdikiDakika = DateTime.Now.Minute;
            int simdikiSaat = DateTime.Now.Hour;
            int simdikiGun = DateTime.Now.Day;
            int simdikiAy = DateTime.Now.Month;
            int simdikiYil = DateTime.Now.Year;
            if(simdikiSaat==alarmSaat && simdikiDakika==alarmDakika && simdikiGun==alarmGun && simdikiYil==alarmYil && simdikiAy==alarmAy)
                Console.Beep(1000,300);
        }
    }
}
