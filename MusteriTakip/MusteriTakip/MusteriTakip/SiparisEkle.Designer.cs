namespace MusteriTakip
{
    partial class SiparisEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            lstUrunler = new ColumnHeader();
            lstMiktar = new ColumnHeader();
            lstFiyat = new ColumnHeader();
            lstAciklama = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            txtMusteriId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnEkle = new Button();
            btnKaydet = new Button();
            cmUrunler = new ComboBox();
            txtMiktar = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtAciklama = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtFiyat = new TextBox();
            label5 = new Label();
            lblMiktar = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            pictureBox4 = new PictureBox();
            button3 = new Button();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { lstUrunler, lstMiktar, lstFiyat, lstAciklama, columnHeader1 });
            listView1.Location = new Point(174, 134);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 390);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // lstUrunler
            // 
            lstUrunler.Text = "Ürünler";
            lstUrunler.TextAlign = HorizontalAlignment.Center;
            lstUrunler.Width = 100;
            // 
            // lstMiktar
            // 
            lstMiktar.Text = "Miktar";
            lstMiktar.TextAlign = HorizontalAlignment.Center;
            lstMiktar.Width = 100;
            // 
            // lstFiyat
            // 
            lstFiyat.Text = "Fiyat";
            lstFiyat.TextAlign = HorizontalAlignment.Center;
            lstFiyat.Width = 100;
            // 
            // lstAciklama
            // 
            lstAciklama.Text = "Açıklama";
            lstAciklama.TextAlign = HorizontalAlignment.Center;
            lstAciklama.Width = 250;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "SiparisDetayId";
            // 
            // txtMusteriId
            // 
            txtMusteriId.Location = new Point(344, 20);
            txtMusteriId.Name = "txtMusteriId";
            txtMusteriId.Size = new Size(121, 23);
            txtMusteriId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 23);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 2;
            label1.Text = "Sipariş verilecek Müşteri Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 63);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 3;
            label2.Text = "Ürünler";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(860, 58);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Listeye Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(860, 92);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(90, 36);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // cmUrunler
            // 
            cmUrunler.FormattingEnabled = true;
            cmUrunler.Location = new Point(344, 60);
            cmUrunler.Name = "cmUrunler";
            cmUrunler.Size = new Size(121, 23);
            cmUrunler.TabIndex = 6;
            cmUrunler.SelectedIndexChanged += cmUrunler_SelectedIndexChanged;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(560, 60);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(117, 23);
            txtMiktar.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(483, 63);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 8;
            label3.Text = "Miktar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(483, 23);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 10;
            label4.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(560, 20);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(373, 23);
            txtAciklama.TabIndex = 9;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(745, 59);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(100, 23);
            txtFiyat.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(693, 62);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 12;
            label5.Text = "Fiyat";
            // 
            // lblMiktar
            // 
            lblMiktar.AutoSize = true;
            lblMiktar.Location = new Point(639, 86);
            lblMiktar.Name = "lblMiktar";
            lblMiktar.Size = new Size(0, 15);
            lblMiktar.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(560, 86);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 14;
            label6.Text = "Stok Miktarı:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.geri;
            pictureBox1.Location = new Point(83, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(2, 39);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 23;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.anasayfa;
            pictureBox4.Location = new Point(83, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(22, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(2, 10);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 21;
            button3.Text = "Anasayfa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(755, 92);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(90, 36);
            btnSil.TabIndex = 25;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // SiparisEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 536);
            Controls.Add(btnSil);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox4);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(lblMiktar);
            Controls.Add(label5);
            Controls.Add(txtFiyat);
            Controls.Add(label4);
            Controls.Add(txtAciklama);
            Controls.Add(label3);
            Controls.Add(txtMiktar);
            Controls.Add(cmUrunler);
            Controls.Add(btnKaydet);
            Controls.Add(btnEkle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMusteriId);
            Controls.Add(listView1);
            Name = "SiparisEkle";
            Text = "SiparisEkle";
            Load += SiparisEkle_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private TextBox txtMusteriId;
        private Label label1;
        private Label label2;
        private Button btnEkle;
        private Button btnKaydet;
        private ComboBox cmUrunler;
        private ColumnHeader lstUrunler;
        private ColumnHeader lstMiktar;
        private ColumnHeader lstFiyat;
        private TextBox txtMiktar;
        private Label label3;
        private Label label4;
        private TextBox txtAciklama;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtFiyat;
        private Label label5;
        private Label lblMiktar;
        private Label label6;
        private ColumnHeader lstAciklama;
        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox pictureBox4;
        private Button button3;
        private Button btnSil;
        private ColumnHeader columnHeader1;
    }
}