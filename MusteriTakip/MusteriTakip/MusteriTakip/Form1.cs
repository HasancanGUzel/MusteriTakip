using MusteriTakip.EfCore;
using static System.Net.Mime.MediaTypeNames;

namespace MusteriTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MusteriTakipContext context = new MusteriTakipContext();

        private void cbGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGoster.Checked)
            {
                txtSifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
           string KullaniciAdi=txtKullaniciAdi.Text;
            string Sifre=txtSifre.Text;
            var admin = context.Admin.ToList();
            if (!string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) && !string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                foreach (var item in admin)
                {
                    if (item.KullaniciAdi == KullaniciAdi && item.Sifre == Sifre)
                    {
                        Menu mn = new Menu();
                        mn.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanýcý Adý veya Þifre Hatalý");
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Lütfen alanlarý gerekli þekilde doldurun");
                return; 
            }


        }
    }
}
