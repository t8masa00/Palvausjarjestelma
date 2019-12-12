using System;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.ComponentModel;

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
        int lukitus = 0;
        int stop;

        string ponton_lampo;
        string sisa_lampo;
        string kokonaisaika;

        //PI-säätimen muuttujat
        float kp = 2.1533f;
        float ki = 0.0098f;
        float erosuure;
        float erosumma;
        float saatimen_kp_osa;
        float saatimen_ki_osa;
        float saatimen_ohj_viesti;
        int testilo;

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
            if (saatimen_ohj_viesti <= 0)
            {
                saatimen_ohj_viesti = 0;
            }

            testilo = (int)saatimen_ohj_viesti;

            if(lukitus == 1 && stop == 0)
            {
                panel2.BackColor = Color.Green;
                Console.WriteLine("rele=1");
                myport.WriteLine("1");
            }
            if(lukitus == 0)
            {
                panel2.BackColor = default;
                Console.WriteLine("rele=0");
                myport.WriteLine("0");
            }

            Console.WriteLine("ohj:" + testilo);
            Console.WriteLine("T:" + lampo);

            //Kokonaisajan asetuksia
            TimeSpan ts = timer.Elapsed;
            string elapsedTime = string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
            kokonaisaika = elapsedTime;
            Console.WriteLine(elapsedTime);
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
            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerAsync();
            start.Enabled = false;
            pysayta.Enabled = true;
            stop = 0;
        }
        private void Pysayta_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer1.Stop();
            timer2.Stop();
            panel1.BackColor = Color.Red;
            label2.Text = "Pysäytetty";
            start.Enabled = true;
            pysayta.Enabled = false;
            stop = 1;
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
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {

                int milliseconds;

                lukitus = 1;
                Console.WriteLine("testilo_backroundissa:" + testilo);
                
                System.Threading.Thread.Sleep(testilo * 100);

                milliseconds = 10000 - (testilo * 100);
                Console.WriteLine("milliseconds_backroundissa:" + milliseconds);
                lukitus = 0;
                
                System.Threading.Thread.Sleep(milliseconds);
            }
            
        }
        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
