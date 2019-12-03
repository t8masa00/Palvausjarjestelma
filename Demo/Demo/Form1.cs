using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Demo
{
    public partial class Form1 : Form
    {
        string in_data; // serial data nucleolta
        private SerialPort myport;
        Stopwatch timer = new Stopwatch();
        // Käyttöliittymään syötettävät lämpötilat
        int aika_kuivaus = 30;
        int aika_savuntuotto = 30;
        int haluttu_lihalampo = 70;
        int haluttu_pontonlampo = 85;
        string ponton_lampo;
        string sisa_lampo;
        string kokonaisaika;
        public Form1()
        {
            ReadData();
            InitializeComponent();
        }

        private void ReadData()
        {
            myport = new SerialPort("COM9", 9600, Parity.None, 8, StopBits.One);
            myport.DataReceived += Myport_DataReceived;
            
            try
            {
                myport.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }
        public void Myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(displaydata_event));

            in_data = myport.ReadLine();
            string[] c = myport.ReadLine().Split(',');

            ponton_lampo = c[0];
            sisa_lampo = c[1];

            float lampo = float.Parse(c[0]);
            int liha = int.Parse(c[1]);

            if (timer1.Enabled == false && timer2.Enabled == false)
            {
                myport.WriteLine("0");
            }
            if (liha >= haluttu_lihalampo)
            {
                myport.WriteLine("0");
            }
            if (lampo >= haluttu_pontonlampo && timer1.Enabled == true)
            {
                myport.WriteLine("0");
            }
            else
            {
                myport.WriteLine("1");
            }
            if (timer2.Enabled == true)
            {
                myport.WriteLine("2");
            }

            //Kokonaisajan asetuksia
            TimeSpan ts = timer.Elapsed;
            string elapsedTime = string.Format("{0:00}:{1:00}", ts.Hours, ts.Minutes);
            kokonaisaika = elapsedTime;
        }
        private void displaydata_event(object sender, EventArgs e)
        {
            string kaika = aika_kuivaus.ToString();
            string saika = aika_savuntuotto.ToString();
            string slampo = haluttu_lihalampo.ToString();
            string plampo = haluttu_pontonlampo.ToString();

            textBox_pontto.Text = plampo;
            textBox_kuivaus.Text = kaika;
            textBox_savuntuotto.Text = saika;
            textBox_liha.Text = slampo;

            label_sisalampo.Text = sisa_lampo;
            label_lampo.Text = ponton_lampo;
            label8.Text = kokonaisaika;
            //throw new NotImplementedException();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            label2.Text = "Kuivaus";
            panel1.BackColor = Color.Green;
            timer1.Interval = aika_kuivaus * 60000;
            timer.Start();
            timer1.Start();
            start.Enabled = false;

        }
        private void Pysayta_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
            label2.Text = "Pysäytetty";
            timer.Stop();
            timer1.Stop();
            timer2.Stop();
            start.Enabled = true;
        }

        private void Button_tempUp2_Click(object sender, EventArgs e)
        {
            aika_kuivaus = aika_kuivaus + 1;
        }

        private void Button_tempDown2_Click(object sender, EventArgs e)
        {
            aika_kuivaus = aika_kuivaus - 1;
        }

        private void Button_tempUp3_Click(object sender, EventArgs e)
        {
            aika_savuntuotto = aika_savuntuotto + 1;
        }

        private void Button_tempDown3_Click(object sender, EventArgs e)
        {
            aika_savuntuotto = aika_savuntuotto - 1;
        }
        private void Button_tempUp_Click(object sender, EventArgs e)
        {
            haluttu_lihalampo = haluttu_lihalampo + 1;
        }

        private void Button_tempDown_Click(object sender, EventArgs e)
        {
            haluttu_lihalampo = haluttu_lihalampo - 1;
        }
        private void Button_tempUp4_Click(object sender, EventArgs e)
        {
            haluttu_pontonlampo = haluttu_pontonlampo + 1;
        }

        private void Button_tempDown4_Click(object sender, EventArgs e)
        {
            haluttu_pontonlampo = haluttu_pontonlampo - 1;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            myport.WriteLine("0");
            Application.Exit();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("timeri 1 tick");
            timer2.Interval = aika_savuntuotto * 60000;
            timer2.Start();
            label2.Text = "Savuntuotto";
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("timeri 2 tick");
            label2.Text = "Palvaus";
        }
    }
}
