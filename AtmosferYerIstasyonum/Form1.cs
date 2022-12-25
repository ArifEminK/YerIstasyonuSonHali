using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using System.Data.Common;

namespace AtmosferYerIstasyonum
{
    public partial class atmosferYerIstasyonu : Form
    {
        public atmosferYerIstasyonu()
        {
            InitializeComponent();
        }
        int i = 0;
        private int Gelen_paket_sayisi;
        private string veri;
        FirestoreDb database;
        void Add_Document_with_CustomID()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"denemedataseti.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            database = FirestoreDb.Create("denemedataseti");
            string dataname = label_Tarih.Text + " " + label_Saat.Text;

            DocumentReference DOC = database.Collection("Atmosfer Deneme Verileri").Document(dataname);
            //DocumentReference DOC = database.Collection("Add_Document_with_CustomID").Document("Deneme");
            Dictionary<string, object> data1 = new Dictionary<string, object>()
            {
                {"Yükseklik", textBox_yukseklik.Text },
                {"Basınç", textBox_basinc.Text },
                {"Sıcaklık", textBox_sicaklik.Text },
                {"Nem", textBox_nem.Text },
                {"Enlem", textBox_enlem.Text },
                {"Boylam", textBox_boylam.Text },
                {"Hız", textBox_hiz.Text },
                {"Hava Kalitesi", textBox_havaKalitesi.Text }
            };
            DOC.SetAsync(data1);
        }



        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                veri = serialPort1.ReadLine();
                this.Invoke(new EventHandler(Displayveri));
            }
            catch
            {

            }

        }

        private void Displayveri(object sender, EventArgs e)
        {
            try
            {
                string[] value = veri.Split('/');
                Gelen_paket_sayisi = int.Parse(value[0]);
                textBox_yukseklik.Text = value[1];
                textBox_basinc.Text = value[2];
                textBox_sicaklik.Text = value[3];
                textBox_nem.Text = value[4];
                textBox_enlem.Text = value[5];
                textBox_boylam.Text = value[6];
                textBox_hiz.Text = value[7];
                textBox_havaKalitesi.Text = value[8];


                double Hava_kalitesi = Convert.ToDouble(value[8]);
                double Basinc = Convert.ToDouble(value[2]);
                double Sicaklik = Convert.ToDouble(value[3]);


                this.chart_havakalitesi.Series[0].Points.AddXY(Gelen_paket_sayisi.ToString(), Hava_kalitesi);
                this.chart_basinc.Series[0].Points.AddXY(Gelen_paket_sayisi.ToString(), Basinc);
            }
            catch
            {


            }
        }

        private void button_baglan_Click_1(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox_port.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox_baudrate.Text);
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.DataBits = 8;
                serialPort1.Open();
                button_baglan.Enabled = false;
                button_baglantıyıkes.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ("Hata1"));
            }
        }

        private void button_baglantıyıkes_Click_1(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                button_baglan.Enabled = true;
                button_baglantıyıkes.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ("Hata2"));
            }
        }



        private void button_dark_Click_1(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        }

        private void button_light_Click_1(object sender, EventArgs e)
        {
            BackColor = Color.WhiteSmoke;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_Tarih.Text = DateTime.Now.ToLongDateString();
            label_Saat.Text = DateTime.Now.ToLongTimeString();
            textBox_basinc.Text = i.ToString();
            textBox_boylam.Text = i.ToString();
            textBox_enlem.Text = i.ToString();
            textBox_havaKalitesi.Text = i.ToString();
            textBox_hiz.Text = i.ToString();
            textBox_nem.Text = i.ToString();
            textBox_sicaklik.Text = i.ToString();
            textBox_yukseklik.Text = i.ToString();
            //this.chart_havakalitesi.Series[0].Points.AddXY(Sicaklik, Hava_kalitesi);
            //this.chart_basinc.Series[0].Points.AddXY(Sicaklik, Basinc);
            i = i + 1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Add_Document_with_CustomID();
        }

        private void button_KayıtBaslat_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button_KayıtDurdur_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void atmosferYerIstasyonu_Load(object sender, EventArgs e)
        {
            timer1.Start();


            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox_port.Items.Add(port);
                comboBox_baudrate.Text = "";


                Control.CheckForIllegalCrossThreadCalls = false;
            }
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }
    }
}
