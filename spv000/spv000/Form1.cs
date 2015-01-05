using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;  //seri port eklendi


namespace spv000
{
    public partial class Form1 : Form
    {
        string indata = string.Empty;
        public Form1()
        {
            InitializeComponent();
            getportnames();// uygun comportları bu fonksıyon ıle alıp port adlı comboboxxa basıyorum bununla
            comboBoxBaudR.SelectedIndex = 6;  //default  set for baudrate-9600
            comboBoxDataB.SelectedIndex = 1;  //default  set for data bits-8
            comboBoxParity.SelectedIndex = 0; //default  set for parity -none
            comboBoxStopB.SelectedIndex = 0;  //default  set for stop bits -one
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

            // grafik verilerinde gelen verinin basında daıma $ isareti bulancak
            // dolar ısareti bulunmayan datalar text olarak algılancak ve text box ta basılacak bunu algılamak ıcın
            //Substring ile okunan data nın ilk harfi kontrol ediliyor detaylı kullanım ıcın asagıyı ıncele
            /*
             
             string metin = “Bilişim Teknolojileri”;
               Console.WriteLine(metin.Substring(3)); //işim Teknolojileri
             
             * 
             * burada 3. harften sonra cumleyi kesiyor ve gerisini alıyor. eger 3. harften belli bir sayıda harf alınamak ıstenırse
             * string metin = “Bilişim Teknolojileri”;
                Console.WriteLine(metin.Substring(3,4)); //işim    
             * olarak kullan burada 3. harften kesımp 4 5 6 7 harleri alıyor yanı 4 harfi
             * 
             
             */

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
                //status.BackColor = Color.Green;
            }

        }

        private void closeport_Click_Click(object sender, EventArgs e)
        {
            if (myserial.IsOpen)
            {
                myserial.Close();
                //status.BackColor = Color.Red;
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



    }
}
