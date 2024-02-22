namespace MusteriTakip
{
    partial class MusteriEkle
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
            textAd = new TextBox();
            textSoyad = new TextBox();
            textTelNo = new TextBox();
            textTcNo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnEkle = new Button();
            label3 = new Label();
            txtadres = new TextBox();
            pictureBox4 = new PictureBox();
            button3 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textAd
            // 
            textAd.Location = new Point(244, 71);
            textAd.Name = "textAd";
            textAd.Size = new Size(100, 23);
            textAd.TabIndex = 0;
            // 
            // textSoyad
            // 
            textSoyad.Location = new Point(244, 119);
            textSoyad.Name = "textSoyad";
            textSoyad.Size = new Size(104, 23);
            textSoyad.TabIndex = 1;
            // 
            // textTelNo
            // 
            textTelNo.Location = new Point(244, 210);
            textTelNo.MaxLength = 11;
            textTelNo.Name = "textTelNo";
            textTelNo.Size = new Size(206, 23);
            textTelNo.TabIndex = 3;
            // 
            // textTcNo
            // 
            textTcNo.Location = new Point(244, 253);
            textTcNo.MaxLength = 11;
            textTcNo.Name = "textTcNo";
            textTcNo.Size = new Size(100, 23);
            textTcNo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 73);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 5;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 118);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Soyad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 213);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 8;
            label4.Text = "Telefon No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(146, 261);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 9;
            label5.Text = "Tc No";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(350, 352);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(100, 23);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Müşteri Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 170);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 12;
            label3.Text = "Adres";
            // 
            // txtadres
            // 
            txtadres.Location = new Point(244, 162);
            txtadres.Name = "txtadres";
            txtadres.Size = new Size(492, 23);
            txtadres.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.anasayfa;
            pictureBox4.Location = new Point(93, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(22, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "Anasayfa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 41);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.geri;
            pictureBox1.Location = new Point(93, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // MusteriEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(txtadres);
            Controls.Add(btnEkle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textTcNo);
            Controls.Add(textTelNo);
            Controls.Add(textSoyad);
            Controls.Add(textAd);
            Name = "MusteriEkle";
            Text = "MusteriEkle";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textAd;
        private TextBox textSoyad;
        private TextBox textTelNo;
        private TextBox textTcNo;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Button btnEkle;
        private Label label3;
        private TextBox txtadres;
        private PictureBox pictureBox4;
        private Button button3;
        private Button button1;
        private PictureBox pictureBox1;
    }
}