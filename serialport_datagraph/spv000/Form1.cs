using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;  //seri port eklendi
using ZedGraph;


namespace spv000
{
    public partial class Form1 : Form
    {
        string indata = string.Empty;
        double[] data = new double[3];//gelen değerleri grafike atamak için
        
        GraphPane mypane=new GraphPane();
        RollingPointPairList listPointsOne = new RollingPointPairList(100);
        LineItem mycurveone;

        RollingPointPairList listPointstwo = new RollingPointPairList(100);
        LineItem mycurvetwo;

        RollingPointPairList listPointsthree = new RollingPointPairList(100);
        LineItem mycurvethree;

        public Form1()
        {
            InitializeComponent();
         

            getportnames();// uygun comportları bu fonksıyon ıle alıp port adlı comboboxxa basıyorum bununla
            comboBoxBaudR.SelectedIndex = 6;  //default  set for baudrate-9600
            comboBoxDataB.SelectedIndex = 1;  //default  set for data bits-8
            comboBoxParity.SelectedIndex = 0; //default  set for parity -none
            comboBoxStopB.SelectedIndex = 0;  //default  set for stop bits -one

             

             mypane = zedGraphControl1.GraphPane;
             mypane.XAxis.Title.Text = "Time";
             mypane.YAxis.Title.Text = "DATA";
             zedGraphControl1.GraphPane.Title.Text = "Data Graphic";

             zedGraphControl1.Invalidate();
             zedGraphControl1.AxisChange();
             zedGraphControl1.Refresh();
             timer1.Enabled = false;

            




        }


        public void Init()
        {
            myserial.PortName = comboBoxPort.Text;                                           //selected name of port
            myserial.Parity = (Parity)Enum.Parse(typeof(Parity), comboBoxParity.Text);   //selected parity 
            myserial.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBoxStopB.Text);//selected stopbits
            myserial.DataBits = int.Parse(comboBoxDataB.Text);                           //selected data bits
            myserial.BaudRate = int.Parse(comboBoxBaudR.Text);                             //selected baudrate
            myserial.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);//received even handler
            


        }
        public void getportnames()
        {
            string[] portnames = SerialPort.GetPortNames(); //uygun portlar bunula alınıyor strınge aktarılıyor 
            comboBoxPort.Items.Clear();                     //portname adlı combo boxta bir item varsa onlar sılınıyor 

            foreach (string s in portnames)                 //portcombobox ına bulunan portlar eklenıyor
            {
                comboBoxPort.Items.Add(s);
            }

            if (comboBoxPort.Items.Count > 0)   //port bulundumu dıye ıtem sayısına bakılıyor 
            {
                comboBoxPort.SelectedIndex = 0;
            }
            else
            {
                comboBoxPort.Text = "No COM Port "; //port bulunamadıysa uyarı mesajı veriliyor portcomboda
            }
        }/** uygun comportları arama fonksıyonu **/


        public void transmit()
        {

            try
            {
                if (myserial.IsOpen)
                {

                    myserial.Write(richTextBoxSend.Text); //rich box taki veri serial porttan basılıyor 
                    System.Threading.Thread.Sleep(150);// sistem gecikme


                }
            }
            catch (Exception)
            {
                MessageBox.Show("com port uygun degil!!!"); //port uygun deilse uyarı mesaji basiliyor
            }
        }/*******************veri basma islemi bitiyor******************/

        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            
            

            try
            {
                indata = myserial.ReadLine();
                this.Invoke(new EventHandler(DisplayText));
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata:" + hata.Message);
            }
            
        }/*********************************************************/


        private void DisplayText(object s, EventArgs e)
        {

            string ctrl = indata.Substring(0, 1);
            if (true == timer1.Enabled)
            {

                if ("@" == ctrl)
                {
                    string ctrl1 = indata.Substring(1, indata.Length - 1);
                    for (int i = 0; i < ctrl1.Split(',').Length; i++)
                    {
                        data[i] = Convert.ToDouble(ctrl1.Split(',')[i]);
                    }

                    label6.Text = Convert.ToString(data[0]);
                    label7.Text = Convert.ToString(data[1]);
                    label8.Text = Convert.ToString(data[2]);
                }
            }


            rtbEkran.Text += indata;
            rtbEkran.SelectionStart = rtbEkran.Text.Length;
            rtbEkran.ScrollToCaret();
            indata = String.Empty;
        }

        private void Openport_Click_Click(object sender, EventArgs e)
        {
            if (myserial.IsOpen)  //com port acıkmı deıl mı dıye bakar
            {
                MessageBox.Show("com port zaten acik!!!");
            }
            else
            { 
                Init();
                myserial.Open(); 
                status.BackColor = Color.Green;
                
            }

        }

        private void closeport_Click_Click(object sender, EventArgs e)
        {
            if (myserial.IsOpen)
            {
                myserial.Close();
                status.BackColor = Color.Red;
                
            }
            else
            {
                MessageBox.Show("com port zaten kapali!!!");
            }
        }

        private void clear_Click_Click(object sender, EventArgs e)
        {
            // alma ve gonderme boxları siliniyor.
            richTextBoxSend.Clear();
            rtbEkran.Clear();
        }

        private void buttonSend_Click_Click_Click(object sender, EventArgs e)
        {
            transmit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(label12.Text);
            sayi++;
            label12.Text = sayi.ToString();


            mypane = zedGraphControl1.GraphPane;


            double x = Convert.ToDouble(label12.Text);//zaman bu

            double y1 = data[0];
            listPointsOne.Add(x, y1);
            mycurveone = mypane.AddCurve(null, listPointsOne, Color.Blue, SymbolType.Square);


            double y2 = data[1];
            listPointstwo.Add(x, y2);
            mycurvetwo = mypane.AddCurve(null, listPointstwo, Color.Red, SymbolType.Circle);



            double y3 = data[2];
            listPointsthree.Add(x, y3);
            mycurvethree = mypane.AddCurve(null, listPointsthree, Color.Green, SymbolType.Plus);


            zedGraphControl1.Invalidate();
            zedGraphControl1.AxisChange();
            zedGraphControl1.Refresh();
            

        }

        private void timer_aktif_etme_Click(object sender, EventArgs e)//timer aktif ediyor
        {
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)//timer pasif ediyor
        {
            timer1.Enabled = false;
            

        }




    }
}
