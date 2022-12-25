
namespace AtmosferYerIstasyonum
{
    partial class atmosferYerIstasyonu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label_yukseklik = new System.Windows.Forms.Label();
            this.textBox_yukseklik = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label_metre = new System.Windows.Forms.Label();
            this.label_mbar = new System.Windows.Forms.Label();
            this.textBox_basinc = new System.Windows.Forms.TextBox();
            this.label_basinc = new System.Windows.Forms.Label();
            this.label_c = new System.Windows.Forms.Label();
            this.textBox_sicaklik = new System.Windows.Forms.TextBox();
            this.label_sicaklik = new System.Windows.Forms.Label();
            this.label_yuzde = new System.Windows.Forms.Label();
            this.textBox_nem = new System.Windows.Forms.TextBox();
            this.label_nem = new System.Windows.Forms.Label();
            this.textBox_enlem = new System.Windows.Forms.TextBox();
            this.label_enlem = new System.Windows.Forms.Label();
            this.textBox_boylam = new System.Windows.Forms.TextBox();
            this.label_boylam = new System.Windows.Forms.Label();
            this.label_ms = new System.Windows.Forms.Label();
            this.textBox_hiz = new System.Windows.Forms.TextBox();
            this.label_hiz = new System.Windows.Forms.Label();
            this.label_ucusverileri = new System.Windows.Forms.Label();
            this.label_serialport = new System.Windows.Forms.Label();
            this.label_port = new System.Windows.Forms.Label();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.label_baudrate = new System.Windows.Forms.Label();
            this.comboBox_baudrate = new System.Windows.Forms.ComboBox();
            this.button_baglan = new System.Windows.Forms.Button();
            this.label_atmosfer = new System.Windows.Forms.Label();
            this.label_grafikler = new System.Windows.Forms.Label();
            this.chart_havakalitesi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_basinc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_haritalandirma = new System.Windows.Forms.Label();
            this.label_havaKalitesi = new System.Windows.Forms.Label();
            this.textBox_havaKalitesi = new System.Windows.Forms.TextBox();
            this.button_baglantıyıkes = new System.Windows.Forms.Button();
            this.button_dark = new System.Windows.Forms.Button();
            this.button_light = new System.Windows.Forms.Button();
            this.label_Tarih = new System.Windows.Forms.Label();
            this.label_Saat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button_KayıtBaslat = new System.Windows.Forms.Button();
            this.button_KayıtDurdur = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart_havakalitesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_basinc)).BeginInit();
            this.SuspendLayout();
            // 
            // label_yukseklik
            // 
            this.label_yukseklik.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_yukseklik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_yukseklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_yukseklik.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_yukseklik.Location = new System.Drawing.Point(53, 340);
            this.label_yukseklik.Name = "label_yukseklik";
            this.label_yukseklik.Size = new System.Drawing.Size(158, 78);
            this.label_yukseklik.TabIndex = 0;
            this.label_yukseklik.Text = "Yükseklik";
            this.label_yukseklik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_yukseklik
            // 
            this.textBox_yukseklik.BackColor = System.Drawing.Color.White;
            this.textBox_yukseklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_yukseklik.Location = new System.Drawing.Point(84, 375);
            this.textBox_yukseklik.Name = "textBox_yukseklik";
            this.textBox_yukseklik.Size = new System.Drawing.Size(90, 27);
            this.textBox_yukseklik.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label_metre
            // 
            this.label_metre.AutoSize = true;
            this.label_metre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_metre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_metre.Location = new System.Drawing.Point(180, 382);
            this.label_metre.Name = "label_metre";
            this.label_metre.Size = new System.Drawing.Size(23, 20);
            this.label_metre.TabIndex = 3;
            this.label_metre.Text = "m";
            // 
            // label_mbar
            // 
            this.label_mbar.AutoSize = true;
            this.label_mbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_mbar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_mbar.Location = new System.Drawing.Point(353, 386);
            this.label_mbar.Name = "label_mbar";
            this.label_mbar.Size = new System.Drawing.Size(47, 20);
            this.label_mbar.TabIndex = 6;
            this.label_mbar.Text = "mbar";
            // 
            // textBox_basinc
            // 
            this.textBox_basinc.BackColor = System.Drawing.Color.White;
            this.textBox_basinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_basinc.Location = new System.Drawing.Point(257, 379);
            this.textBox_basinc.Name = "textBox_basinc";
            this.textBox_basinc.Size = new System.Drawing.Size(90, 27);
            this.textBox_basinc.TabIndex = 5;
            // 
            // label_basinc
            // 
            this.label_basinc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_basinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_basinc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_basinc.Location = new System.Drawing.Point(245, 340);
            this.label_basinc.Name = "label_basinc";
            this.label_basinc.Size = new System.Drawing.Size(158, 78);
            this.label_basinc.TabIndex = 4;
            this.label_basinc.Text = "Basınç";
            this.label_basinc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_c
            // 
            this.label_c.AutoSize = true;
            this.label_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_c.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_c.Location = new System.Drawing.Point(548, 389);
            this.label_c.Name = "label_c";
            this.label_c.Size = new System.Drawing.Size(28, 20);
            this.label_c.TabIndex = 9;
            this.label_c.Text = "°C";
            // 
            // textBox_sicaklik
            // 
            this.textBox_sicaklik.BackColor = System.Drawing.Color.White;
            this.textBox_sicaklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_sicaklik.Location = new System.Drawing.Point(452, 382);
            this.textBox_sicaklik.Name = "textBox_sicaklik";
            this.textBox_sicaklik.Size = new System.Drawing.Size(90, 27);
            this.textBox_sicaklik.TabIndex = 8;
            // 
            // label_sicaklik
            // 
            this.label_sicaklik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_sicaklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_sicaklik.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_sicaklik.Location = new System.Drawing.Point(435, 340);
            this.label_sicaklik.Name = "label_sicaklik";
            this.label_sicaklik.Size = new System.Drawing.Size(158, 78);
            this.label_sicaklik.TabIndex = 7;
            this.label_sicaklik.Text = "Sıcaklık";
            this.label_sicaklik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_yuzde
            // 
            this.label_yuzde.AutoSize = true;
            this.label_yuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_yuzde.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_yuzde.Location = new System.Drawing.Point(656, 389);
            this.label_yuzde.Name = "label_yuzde";
            this.label_yuzde.Size = new System.Drawing.Size(24, 20);
            this.label_yuzde.TabIndex = 12;
            this.label_yuzde.Text = "%";
            // 
            // textBox_nem
            // 
            this.textBox_nem.BackColor = System.Drawing.Color.White;
            this.textBox_nem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_nem.Location = new System.Drawing.Point(686, 382);
            this.textBox_nem.Name = "textBox_nem";
            this.textBox_nem.Size = new System.Drawing.Size(90, 27);
            this.textBox_nem.TabIndex = 11;
            // 
            // label_nem
            // 
            this.label_nem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_nem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_nem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_nem.Location = new System.Drawing.Point(629, 340);
            this.label_nem.Name = "label_nem";
            this.label_nem.Size = new System.Drawing.Size(158, 78);
            this.label_nem.TabIndex = 10;
            this.label_nem.Text = "Nem";
            this.label_nem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_enlem
            // 
            this.textBox_enlem.BackColor = System.Drawing.Color.White;
            this.textBox_enlem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_enlem.Location = new System.Drawing.Point(857, 382);
            this.textBox_enlem.Name = "textBox_enlem";
            this.textBox_enlem.Size = new System.Drawing.Size(91, 27);
            this.textBox_enlem.TabIndex = 14;
            // 
            // label_enlem
            // 
            this.label_enlem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_enlem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_enlem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_enlem.Location = new System.Drawing.Point(821, 340);
            this.label_enlem.Name = "label_enlem";
            this.label_enlem.Size = new System.Drawing.Size(158, 78);
            this.label_enlem.TabIndex = 13;
            this.label_enlem.Text = "Enlem";
            this.label_enlem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_boylam
            // 
            this.textBox_boylam.BackColor = System.Drawing.Color.White;
            this.textBox_boylam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_boylam.Location = new System.Drawing.Point(1056, 382);
            this.textBox_boylam.Name = "textBox_boylam";
            this.textBox_boylam.Size = new System.Drawing.Size(90, 27);
            this.textBox_boylam.TabIndex = 17;
            // 
            // label_boylam
            // 
            this.label_boylam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_boylam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_boylam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_boylam.Location = new System.Drawing.Point(1023, 340);
            this.label_boylam.Name = "label_boylam";
            this.label_boylam.Size = new System.Drawing.Size(158, 78);
            this.label_boylam.TabIndex = 16;
            this.label_boylam.Text = "Boylam";
            this.label_boylam.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_ms
            // 
            this.label_ms.AutoSize = true;
            this.label_ms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ms.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_ms.Location = new System.Drawing.Point(1335, 389);
            this.label_ms.Name = "label_ms";
            this.label_ms.Size = new System.Drawing.Size(37, 20);
            this.label_ms.TabIndex = 21;
            this.label_ms.Text = "m/s";
            // 
            // textBox_hiz
            // 
            this.textBox_hiz.BackColor = System.Drawing.Color.White;
            this.textBox_hiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_hiz.Location = new System.Drawing.Point(1239, 382);
            this.textBox_hiz.Name = "textBox_hiz";
            this.textBox_hiz.Size = new System.Drawing.Size(90, 27);
            this.textBox_hiz.TabIndex = 20;
            // 
            // label_hiz
            // 
            this.label_hiz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_hiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_hiz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_hiz.Location = new System.Drawing.Point(1226, 340);
            this.label_hiz.Name = "label_hiz";
            this.label_hiz.Size = new System.Drawing.Size(158, 78);
            this.label_hiz.TabIndex = 19;
            this.label_hiz.Text = "Hız";
            this.label_hiz.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_ucusverileri
            // 
            this.label_ucusverileri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ucusverileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ucusverileri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_ucusverileri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_ucusverileri.Location = new System.Drawing.Point(45, 304);
            this.label_ucusverileri.Name = "label_ucusverileri";
            this.label_ucusverileri.Size = new System.Drawing.Size(1784, 121);
            this.label_ucusverileri.TabIndex = 22;
            this.label_ucusverileri.Text = "Uçuş verileri";
            // 
            // label_serialport
            // 
            this.label_serialport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_serialport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_serialport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_serialport.Location = new System.Drawing.Point(1048, 140);
            this.label_serialport.Name = "label_serialport";
            this.label_serialport.Size = new System.Drawing.Size(781, 142);
            this.label_serialport.TabIndex = 23;
            this.label_serialport.Text = "Serial Port Bağlantısı";
            // 
            // label_port
            // 
            this.label_port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_port.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_port.Location = new System.Drawing.Point(1135, 192);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(207, 73);
            this.label_port.TabIndex = 24;
            this.label_port.Text = "Port";
            this.label_port.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox_port
            // 
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Location = new System.Drawing.Point(1183, 226);
            this.comboBox_port.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(121, 24);
            this.comboBox_port.TabIndex = 25;
            // 
            // label_baudrate
            // 
            this.label_baudrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_baudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_baudrate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_baudrate.Location = new System.Drawing.Point(1378, 192);
            this.label_baudrate.Name = "label_baudrate";
            this.label_baudrate.Size = new System.Drawing.Size(236, 73);
            this.label_baudrate.TabIndex = 26;
            this.label_baudrate.Text = "Baud Rate";
            this.label_baudrate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox_baudrate
            // 
            this.comboBox_baudrate.FormattingEnabled = true;
            this.comboBox_baudrate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "115200"});
            this.comboBox_baudrate.Location = new System.Drawing.Point(1431, 226);
            this.comboBox_baudrate.Name = "comboBox_baudrate";
            this.comboBox_baudrate.Size = new System.Drawing.Size(121, 24);
            this.comboBox_baudrate.TabIndex = 27;
            // 
            // button_baglan
            // 
            this.button_baglan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_baglan.Location = new System.Drawing.Point(1642, 163);
            this.button_baglan.Margin = new System.Windows.Forms.Padding(4);
            this.button_baglan.Name = "button_baglan";
            this.button_baglan.Size = new System.Drawing.Size(171, 48);
            this.button_baglan.TabIndex = 28;
            this.button_baglan.Text = "Bağlan";
            this.button_baglan.UseVisualStyleBackColor = true;
            this.button_baglan.Click += new System.EventHandler(this.button_baglan_Click_1);
            // 
            // label_atmosfer
            // 
            this.label_atmosfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_atmosfer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_atmosfer.Location = new System.Drawing.Point(614, 51);
            this.label_atmosfer.Name = "label_atmosfer";
            this.label_atmosfer.Size = new System.Drawing.Size(706, 51);
            this.label_atmosfer.TabIndex = 29;
            this.label_atmosfer.Text = "ATMOSFER YER İSTASYONU";
            // 
            // label_grafikler
            // 
            this.label_grafikler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_grafikler.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_grafikler.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_grafikler.Location = new System.Drawing.Point(1048, 448);
            this.label_grafikler.Name = "label_grafikler";
            this.label_grafikler.Size = new System.Drawing.Size(781, 526);
            this.label_grafikler.TabIndex = 31;
            this.label_grafikler.Text = "Grafikler";
            // 
            // chart_havakalitesi
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_havakalitesi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_havakalitesi.Legends.Add(legend1);
            this.chart_havakalitesi.Location = new System.Drawing.Point(1063, 552);
            this.chart_havakalitesi.Name = "chart_havakalitesi";
            this.chart_havakalitesi.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Hava Kalitesi";
            this.chart_havakalitesi.Series.Add(series1);
            this.chart_havakalitesi.Size = new System.Drawing.Size(373, 329);
            this.chart_havakalitesi.TabIndex = 32;
            this.chart_havakalitesi.Text = "Hava Kalitesi";
            // 
            // chart_basinc
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_basinc.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_basinc.Legends.Add(legend2);
            this.chart_basinc.Location = new System.Drawing.Point(1442, 552);
            this.chart_basinc.Name = "chart_basinc";
            this.chart_basinc.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_basinc.Series.Add(series2);
            this.chart_basinc.Size = new System.Drawing.Size(371, 329);
            this.chart_basinc.TabIndex = 33;
            this.chart_basinc.Text = "chart2";
            // 
            // label_haritalandirma
            // 
            this.label_haritalandirma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_haritalandirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_haritalandirma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_haritalandirma.Location = new System.Drawing.Point(45, 448);
            this.label_haritalandirma.Name = "label_haritalandirma";
            this.label_haritalandirma.Size = new System.Drawing.Size(978, 526);
            this.label_haritalandirma.TabIndex = 35;
            this.label_haritalandirma.Text = "Haritalandırma";
            // 
            // label_havaKalitesi
            // 
            this.label_havaKalitesi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_havaKalitesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_havaKalitesi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_havaKalitesi.Location = new System.Drawing.Point(1425, 340);
            this.label_havaKalitesi.Name = "label_havaKalitesi";
            this.label_havaKalitesi.Size = new System.Drawing.Size(158, 78);
            this.label_havaKalitesi.TabIndex = 36;
            this.label_havaKalitesi.Text = "Hava Kalitesi";
            this.label_havaKalitesi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_havaKalitesi
            // 
            this.textBox_havaKalitesi.Location = new System.Drawing.Point(1445, 384);
            this.textBox_havaKalitesi.Name = "textBox_havaKalitesi";
            this.textBox_havaKalitesi.Size = new System.Drawing.Size(120, 22);
            this.textBox_havaKalitesi.TabIndex = 38;
            // 
            // button_baglantıyıkes
            // 
            this.button_baglantıyıkes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_baglantıyıkes.Location = new System.Drawing.Point(1642, 217);
            this.button_baglantıyıkes.Name = "button_baglantıyıkes";
            this.button_baglantıyıkes.Size = new System.Drawing.Size(171, 48);
            this.button_baglantıyıkes.TabIndex = 39;
            this.button_baglantıyıkes.Text = "Bağlantıyı Kes";
            this.button_baglantıyıkes.UseVisualStyleBackColor = true;
            this.button_baglantıyıkes.Click += new System.EventHandler(this.button_baglantıyıkes_Click_1);
            // 
            // button_dark
            // 
            this.button_dark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_dark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_dark.Location = new System.Drawing.Point(1725, 26);
            this.button_dark.Margin = new System.Windows.Forms.Padding(4);
            this.button_dark.Name = "button_dark";
            this.button_dark.Size = new System.Drawing.Size(48, 48);
            this.button_dark.TabIndex = 40;
            this.button_dark.UseVisualStyleBackColor = false;
            this.button_dark.Click += new System.EventHandler(this.button_dark_Click_1);
            // 
            // button_light
            // 
            this.button_light.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_light.Location = new System.Drawing.Point(1781, 26);
            this.button_light.Margin = new System.Windows.Forms.Padding(4);
            this.button_light.Name = "button_light";
            this.button_light.Size = new System.Drawing.Size(48, 48);
            this.button_light.TabIndex = 41;
            this.button_light.UseVisualStyleBackColor = true;
            this.button_light.Click += new System.EventHandler(this.button_light_Click_1);
            // 
            // label_Tarih
            // 
            this.label_Tarih.AutoSize = true;
            this.label_Tarih.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Tarih.Location = new System.Drawing.Point(1638, 81);
            this.label_Tarih.Name = "label_Tarih";
            this.label_Tarih.Size = new System.Drawing.Size(42, 21);
            this.label_Tarih.TabIndex = 42;
            this.label_Tarih.Text = "Tarih";
            // 
            // label_Saat
            // 
            this.label_Saat.AutoSize = true;
            this.label_Saat.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Saat.Location = new System.Drawing.Point(1638, 108);
            this.label_Saat.Name = "label_Saat";
            this.label_Saat.Size = new System.Drawing.Size(40, 21);
            this.label_Saat.TabIndex = 43;
            this.label_Saat.Text = "Saat";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button_KayıtBaslat
            // 
            this.button_KayıtBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_KayıtBaslat.Location = new System.Drawing.Point(1590, 333);
            this.button_KayıtBaslat.Margin = new System.Windows.Forms.Padding(4);
            this.button_KayıtBaslat.Name = "button_KayıtBaslat";
            this.button_KayıtBaslat.Size = new System.Drawing.Size(223, 40);
            this.button_KayıtBaslat.TabIndex = 44;
            this.button_KayıtBaslat.Text = "Veri Kaydını Başlat";
            this.button_KayıtBaslat.UseVisualStyleBackColor = true;
            this.button_KayıtBaslat.Click += new System.EventHandler(this.button_KayıtBaslat_Click);
            // 
            // button_KayıtDurdur
            // 
            this.button_KayıtDurdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_KayıtDurdur.Location = new System.Drawing.Point(1590, 377);
            this.button_KayıtDurdur.Margin = new System.Windows.Forms.Padding(4);
            this.button_KayıtDurdur.Name = "button_KayıtDurdur";
            this.button_KayıtDurdur.Size = new System.Drawing.Size(223, 40);
            this.button_KayıtDurdur.TabIndex = 45;
            this.button_KayıtDurdur.Text = "Veri Kaydını Durdur";
            this.button_KayıtDurdur.UseVisualStyleBackColor = true;
            this.button_KayıtDurdur.Click += new System.EventHandler(this.button_KayıtDurdur_Click);
            // 
            // atmosferYerIstasyonu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1870, 1009);
            this.Controls.Add(this.button_KayıtDurdur);
            this.Controls.Add(this.button_KayıtBaslat);
            this.Controls.Add(this.label_Saat);
            this.Controls.Add(this.label_Tarih);
            this.Controls.Add(this.button_light);
            this.Controls.Add(this.button_dark);
            this.Controls.Add(this.button_baglantıyıkes);
            this.Controls.Add(this.textBox_havaKalitesi);
            this.Controls.Add(this.label_havaKalitesi);
            this.Controls.Add(this.label_haritalandirma);
            this.Controls.Add(this.chart_basinc);
            this.Controls.Add(this.chart_havakalitesi);
            this.Controls.Add(this.label_grafikler);
            this.Controls.Add(this.label_atmosfer);
            this.Controls.Add(this.button_baglan);
            this.Controls.Add(this.comboBox_baudrate);
            this.Controls.Add(this.label_baudrate);
            this.Controls.Add(this.comboBox_port);
            this.Controls.Add(this.label_port);
            this.Controls.Add(this.label_serialport);
            this.Controls.Add(this.label_ms);
            this.Controls.Add(this.textBox_hiz);
            this.Controls.Add(this.label_hiz);
            this.Controls.Add(this.textBox_boylam);
            this.Controls.Add(this.label_boylam);
            this.Controls.Add(this.textBox_enlem);
            this.Controls.Add(this.label_enlem);
            this.Controls.Add(this.label_yuzde);
            this.Controls.Add(this.textBox_nem);
            this.Controls.Add(this.label_nem);
            this.Controls.Add(this.label_c);
            this.Controls.Add(this.textBox_sicaklik);
            this.Controls.Add(this.label_sicaklik);
            this.Controls.Add(this.label_mbar);
            this.Controls.Add(this.textBox_basinc);
            this.Controls.Add(this.label_basinc);
            this.Controls.Add(this.label_metre);
            this.Controls.Add(this.textBox_yukseklik);
            this.Controls.Add(this.label_yukseklik);
            this.Controls.Add(this.label_ucusverileri);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "atmosferYerIstasyonu";
            this.Text = "s";
            this.Load += new System.EventHandler(this.atmosferYerIstasyonu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_havakalitesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_basinc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //Label
        private System.Windows.Forms.Label label_yukseklik;
        private System.Windows.Forms.Label label_metre;
        private System.Windows.Forms.Label label_mbar;
        private System.Windows.Forms.Label label_basinc;
        private System.Windows.Forms.Label label_c;
        private System.Windows.Forms.Label label_sicaklik;
        private System.Windows.Forms.Label label_yuzde;
        private System.Windows.Forms.Label label_nem;
        private System.Windows.Forms.Label label_enlem;
        private System.Windows.Forms.Label label_boylam;
        private System.Windows.Forms.Label label_ms;
        private System.Windows.Forms.Label label_hiz;
        private System.Windows.Forms.Label label_ucusverileri;
        private System.Windows.Forms.Label label_serialport;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.Label label_baudrate;
        private System.Windows.Forms.Label label_atmosfer;
        private System.Windows.Forms.Label label_grafikler;
        private System.Windows.Forms.Label label_haritalandirma;
        private System.Windows.Forms.Label label_havaKalitesi;

        //Textbox
        private System.Windows.Forms.TextBox textBox_hiz;
        private System.Windows.Forms.TextBox textBox_boylam;
        private System.Windows.Forms.TextBox textBox_enlem;
        private System.Windows.Forms.TextBox textBox_nem;
        private System.Windows.Forms.TextBox textBox_sicaklik;
        private System.Windows.Forms.TextBox textBox_basinc;
        private System.Windows.Forms.TextBox textBox_yukseklik;
        private System.Windows.Forms.TextBox textBox_havaKalitesi;

        //ComboBox
        private System.Windows.Forms.ComboBox comboBox_port;
        private System.Windows.Forms.ComboBox comboBox_baudrate;

        //Button
        private System.Windows.Forms.Button button_baglan;
        private System.Windows.Forms.Button button_baglantıyıkes;


        private System.Windows.Forms.DataVisualization.Charting.Chart chart_havakalitesi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_basinc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button_dark;
        private System.Windows.Forms.Button button_light;
        private System.Windows.Forms.Label label_Tarih;
        private System.Windows.Forms.Label label_Saat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button_KayıtBaslat;
        private System.Windows.Forms.Button button_KayıtDurdur;
        private System.IO.Ports.SerialPort serialPort2;
    }

}

