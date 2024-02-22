namespace MusteriTakip
{
    partial class UrunEkle
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAd = new TextBox();
            txtBarkodNo = new TextBox();
            txtMiktar = new TextBox();
            txtFiyat = new TextBox();
            btnEkle = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnVar = new Button();
            label5 = new Label();
            txtvarAd = new TextBox();
            txtvarFiyat = new TextBox();
            label8 = new Label();
            label6 = new Label();
            txtvarBarkod = new TextBox();
            txtvarMiktar = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            pictureBox4 = new PictureBox();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 85);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 47);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Barkodu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 124);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 3;
            label3.Text = "Miktar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 156);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 2;
            label4.Text = "Fiyat";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(138, 82);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 2;
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.Location = new Point(138, 47);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new Size(100, 23);
            txtBarkodNo.TabIndex = 1;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(138, 124);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(100, 23);
            txtMiktar.TabIndex = 3;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(138, 156);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(100, 23);
            txtFiyat.TabIndex = 4;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(138, 216);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "Yeni Ürün Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtFiyat);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMiktar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtBarkodNo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Location = new Point(189, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 326);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Ürün";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnVar);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtvarAd);
            groupBox2.Controls.Add(txtvarFiyat);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtvarBarkod);
            groupBox2.Controls.Add(txtvarMiktar);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(564, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(281, 326);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Var Olan Ürün";
            // 
            // btnVar
            // 
            btnVar.Enabled = false;
            btnVar.Location = new Point(121, 216);
            btnVar.Name = "btnVar";
            btnVar.Size = new Size(102, 45);
            btnVar.TabIndex = 19;
            btnVar.Text = "Var Olan Ürün Güncelleme";
            btnVar.UseVisualStyleBackColor = true;
            btnVar.Click += btnVar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 83);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 11;
            label5.Text = "Adı";
            // 
            // txtvarAd
            // 
            txtvarAd.Enabled = false;
            txtvarAd.Location = new Point(125, 83);
            txtvarAd.Name = "txtvarAd";
            txtvarAd.Size = new Size(100, 23);
            txtvarAd.TabIndex = 15;
            // 
            // txtvarFiyat
            // 
            txtvarFiyat.Enabled = false;
            txtvarFiyat.Location = new Point(123, 156);
            txtvarFiyat.Name = "txtvarFiyat";
            txtvarFiyat.Size = new Size(100, 23);
            txtvarFiyat.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 124);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 14;
            label8.Text = "Miktar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 47);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 12;
            label6.Text = "Barkodu";
            // 
            // txtvarBarkod
            // 
            txtvarBarkod.Location = new Point(125, 47);
            txtvarBarkod.Name = "txtvarBarkod";
            txtvarBarkod.Size = new Size(100, 23);
            txtvarBarkod.TabIndex = 16;
            txtvarBarkod.TextChanged += txtvarBarkod_TextChanged;
            // 
            // txtvarMiktar
            // 
            txtvarMiktar.Enabled = false;
            txtvarMiktar.Location = new Point(123, 124);
            txtvarMiktar.Name = "txtvarMiktar";
            txtvarMiktar.Size = new Size(100, 23);
            txtvarMiktar.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 156);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 13;
            label7.Text = "Fiyat";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(189, 400);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(656, 150);
            dataGridView1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.geri;
            pictureBox1.Location = new Point(93, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(12, 41);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.anasayfa;
            pictureBox4.Location = new Point(93, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(22, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 0;
            button3.Text = "Anasayfa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // UrunEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 581);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "UrunEkle";
            Load += UrunEkle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAd;
        private TextBox txtBarkodNo;
        private TextBox txtMiktar;
        private TextBox txtFiyat;
        private Button btnEkle;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnVar;
        private Label label5;
        private TextBox txtvarAd;
        private TextBox txtvarFiyat;
        private Label label8;
        private Label label6;
        private TextBox txtvarBarkod;
        private TextBox txtvarMiktar;
        private Label label7;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox pictureBox4;
        private Button button3;
    }
}