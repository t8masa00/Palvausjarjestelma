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
        int lukitus = 1;

        string ponton_lampo;
        string sisa_lampo;
        string kokonaisaika;

        //PI-säätimen muuttujat
        float kp = 3.9411f;
        float ki = 0.009185f;
        float erosuure;
        float erosumma;
        float saatimen_kp_osa;
        float saatimen_ki_osa;
        float saatimen_ohj_viesti;
        int timer_erotus;
        
        public Form1()
        {
            ReadData();
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
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

            panel2.BackColor = default;

            //PI-säätimen asetukset
            erosuure = haluttu_pontonlampo - lampo;
            saatimen_kp_osa = kp * erosuure;
            erosumma = erosumma + erosuure;
            saatimen_ki_osa = ki * erosumma;
            saatimen_ohj_viesti = saatimen_ki_osa + saatimen_kp_osa;

            if (saatimen_ohj_viesti >= 100)
            {
                saatimen_ohj_viesti = 100;
            }
            if(saatimen_ohj_viesti <= 0)
            {
                saatimen_ohj_viesti = 0;
            }

            Console.WriteLine("lukitus:" + lukitus);
            if (lukitus == 0 && timer3.Enabled == false && timer4.Enabled == false)
            {
                timer3.Interval = (int)saatimen_ohj_viesti * 100;
                timer_erotus = 10000 - timer3.Interval;
                timer3.Start();
                Console.WriteLine("timer3:START");
                lukitus = 1;
            }

            if (timer3.Enabled == true)
            {
                myport.WriteLine("1");
                Console.WriteLine("timer3:PÄÄLLÄ");
                panel2.BackColor = Color.Green;
            }
            else if(timer4.Enabled == true)
            {
                myport.WriteLine("0");
                Console.WriteLine("OFF");
            }
            else
            {
                myport.WriteLine("0");
            }

            
            Console.WriteLine("ohj:" + saatimen_ohj_viesti);
            Console.WriteLine("t3:" + timer3.Interval);
            Console.WriteLine("t4:" + timer4.Interval);
            /*
            if (timer.IsRunning == false)
            {
                myport.WriteLine("0");
            }
            else if (liha >= haluttu_lihalampo)
            {
                myport.WriteLine("0");
            }
            else if (lampo >= haluttu_pontonlampo && timer.IsRunning == true)
            {
                myport.WriteLine("0");
            }
            else
            {
                myport.WriteLine("1");
                panel2.BackColor = Color.Green;
            }
            /*
            if (timer1.Enabled == false && timer2.Enabled == false)
            {
                myport.WriteLine("0");
            }
            if (liha >= haluttu_lihalampo)
            {
                myport.WriteLine("0");
            }
            if (lampo >= haluttu_pontonlampo)
            {
                myport.WriteLine("0");
            }
            else
            {
                myport.WriteLine("1");
                panel2.BackColor = Color.Green;
                //Console.WriteLine("else");
            }

            if (timer.IsRunning == true)
            {

                int vahennys = 20;
                if (arvo == 1 || arvo == 0 && lampo >= haluttu_pontonlampo - vahennys && lampo <= haluttu_pontonlampo)
                {
                    arvo = 1;
                    myport.WriteLine("0");
                    Console.WriteLine("if");
                }

                else if (arvo == 2 && lampo > haluttu_pontonlampo || arvo == 1 && lampo >= haluttu_pontonlampo)
                {
                    myport.WriteLine("0");
                    arvo = 2;
                    Console.WriteLine("else if");
                }

                Console.WriteLine(lampo);
            }*/

            Console.WriteLine(lampo);
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
            lukitus = 0;
            start.Enabled = false;
            pysayta.Enabled = true;
        }
        private void Pysayta_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
            label2.Text = "Pysäytetty";
            timer.Stop();
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            Console.WriteLine("timer3:OFF");
            start.Enabled = true;
            pysayta.Enabled = false;
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
            timer2.Interval = aika_savuntuotto * 60000;
            timer2.Start();
            label2.Text = "Savuntuotto";
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = "Palvaus";
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            timer4.Interval = timer_erotus;
            timer4.Start();
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            timer4.Stop();
            lukitus = 0;
        }
    }
}
