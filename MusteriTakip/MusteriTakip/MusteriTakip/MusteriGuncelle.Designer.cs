namespace MusteriTakip
{
    partial class MusteriGuncelle
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
            dataGridView1 = new DataGridView();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtAdres = new TextBox();
            txtTelNo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTcNo = new TextBox();
            txtId = new TextBox();
            btnAra = new Button();
            label6 = new Label();
            groupBox1 = new GroupBox();
            btnGuncelle = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            pictureBox4 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(243, 274);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(441, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtAd
            // 
            txtAd.Enabled = false;
            txtAd.Location = new Point(276, 53);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Enabled = false;
            txtSoyad.Location = new Point(277, 91);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 2;
            // 
            // txtAdres
            // 
            txtAdres.Enabled = false;
            txtAdres.Location = new Point(278, 131);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(100, 23);
            txtAdres.TabIndex = 3;
            // 
            // txtTelNo
            // 
            txtTelNo.Enabled = false;
            txtTelNo.Location = new Point(277, 175);
            txtTelNo.MaxLength = 11;
            txtTelNo.Name = "txtTelNo";
            txtTelNo.Size = new Size(100, 23);
            txtTelNo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 61);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 5;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 99);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(182, 142);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 7;
            label3.Text = "Adres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 177);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 8;
            label4.Text = "Telefon No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 214);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 9;
            label5.Text = "TcNo";
            // 
            // txtTcNo
            // 
            txtTcNo.Enabled = false;
            txtTcNo.Location = new Point(277, 225);
            txtTcNo.MaxLength = 11;
            txtTcNo.Name = "txtTcNo";
            txtTcNo.Size = new Size(100, 23);
            txtTcNo.TabIndex = 10;
            // 
            // txtId
            // 
            txtId.Location = new Point(69, 39);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 11;
            txtId.Text = " ";
            // 
            // btnAra
            // 
            btnAra.Location = new Point(180, 38);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(75, 23);
            btnAra.TabIndex = 12;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 47);
            label6.Name = "label6";
            label6.Size = new Size(17, 15);
            label6.TabIndex = 13;
            label6.Text = "Id";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(btnAra);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(579, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(261, 95);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ara";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Enabled = false;
            btnGuncelle.Location = new Point(412, 225);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 25;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.geri;
            pictureBox1.Location = new Point(86, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(5, 40);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 28;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.anasayfa;
            pictureBox4.Location = new Point(86, 11);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(22, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(5, 11);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 26;
            button3.Text = "Anasayfa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // MusteriGuncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 464);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox4);
            Controls.Add(button3);
            Controls.Add(btnGuncelle);
            Controls.Add(groupBox1);
            Controls.Add(txtTcNo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTelNo);
            Controls.Add(txtAdres);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(dataGridView1);
            Name = "MusteriGuncelle";
            Text = "MusteriGuncelle";
            Load += MusteriGuncelle_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtAdres;
        private TextBox txtTelNo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTcNo;
        private TextBox txtId;
        private Button btnAra;
        private Label label6;
        private GroupBox groupBox1;
        private Button btnGuncelle;
        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox pictureBox4;
        private Button button3;
    }
}