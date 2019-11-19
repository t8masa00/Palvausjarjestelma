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

        private SerialPort myport;

        public Form1()
        {
            InitializeComponent();
        }

        private void ReadData()
        {
            myport = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);

            try
            {
                myport.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        void Myport_DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            string in_data = myport.ReadLine();
            textBox_tempPontto.Text = in_data;
        }

    }
}
