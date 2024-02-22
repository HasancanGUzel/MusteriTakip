namespace MusteriTakip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            cbGoster = new CheckBox();
            btnGiris = new Button();
            txtSifre = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtKullaniciAdi = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(cbGoster);
            panel1.Controls.Add(btnGiris);
            panel1.Controls.Add(txtSifre);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtKullaniciAdi);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(209, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 315);
            panel1.TabIndex = 0;
            // 
            // cbGoster
            // 
            cbGoster.AutoSize = true;
            cbGoster.Location = new Point(120, 159);
            cbGoster.Name = "cbGoster";
            cbGoster.Size = new Size(95, 19);
            cbGoster.TabIndex = 6;
            cbGoster.Text = "Şifreyi Göster";
            cbGoster.UseVisualStyleBackColor = true;
            cbGoster.CheckedChanged += cbGoster_CheckedChanged;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(120, 214);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(155, 23);
            btnGiris.TabIndex = 5;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(120, 130);
            txtSifre.Name = "txtSifre";
            txtSifre.PlaceholderText = "Şifre";
            txtSifre.Size = new Size(142, 23);
            txtSifre.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pasword;
            pictureBox2.Location = new Point(268, 130);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.USER;
            pictureBox1.Location = new Point(268, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(120, 91);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.PlaceholderText = "Kullanıcı Adı";
            txtKullaniciAdi.Size = new Size(142, 23);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(120, 26);
            label1.Name = "label1";
            label1.Size = new Size(142, 39);
            label1.TabIndex = 0;
            label1.Text = "GİRİŞ YAP";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(829, 562);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnGiris;
        private CheckBox cbGoster;
    }
}
