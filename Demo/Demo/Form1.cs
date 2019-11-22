using System;
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
        string in_data;
        private SerialPort myport;
        

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
            if(!int.TryParse(c[0], out int liha));
            if(!int.TryParse(c[1], out int lampo)) ;
            if(!int.TryParse(c[2], out int lampo2)) ;

            if (liha >= 28)
            {
                //Console.WriteLine("buffer = 0");
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

    }
}
