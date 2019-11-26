﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        int aika_kuivaus = 30;
        int aika_savuntuotto = 30;
        int haluttu_sisalampo = 80;
        string sisalampo;
        
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
        private void Myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            in_data = myport.ReadLine();
            string[] c = myport.ReadLine().Split(',');
            Console.WriteLine(c[0]);
            Console.WriteLine(c[1]);
            Console.WriteLine(c[2]);
            sisalampo = c[0];
            if (!int.TryParse(c[0], out int liha));
            if(!int.TryParse(c[1], out int lampo)) ;
            if(!int.TryParse(c[2], out int lampo2)) ;
            
            this.Invoke(new EventHandler(displaydata_event));

            if (liha >= 28)
            {
                myport.WriteLine("1");
            }
            else
            {
                myport.WriteLine("0");
            }
            if (lampo == 55)
            {
                Console.WriteLine("hehe");
            }
            
        }

        private void displaydata_event(object sender, EventArgs e)
        {
            string kaika = aika_kuivaus.ToString();
            string saika = aika_savuntuotto.ToString();
            string slampo = haluttu_sisalampo.ToString();

            textBox_kuivaus.Text = kaika;
            textBox_savuntuotto.Text = saika;
            textBox_liha.Text = slampo;

            label_sisalampo.Text = sisalampo;
            //throw new NotImplementedException();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Interval = aika_kuivaus * 60000;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("timeri");
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
            haluttu_sisalampo = haluttu_sisalampo + 1;
        }

        private void Button_tempDown_Click(object sender, EventArgs e)
        {
            haluttu_sisalampo = haluttu_sisalampo - 1;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
