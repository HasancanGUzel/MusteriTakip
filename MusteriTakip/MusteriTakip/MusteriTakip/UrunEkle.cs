using MusteriTakip.EfCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MusteriTakip
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        MusteriTakipContext context = new MusteriTakipContext();
        void Goster()
        {
            txtvarAd.Enabled = true;
            txtvarMiktar.Enabled = true;
            txtvarFiyat.Enabled = true;
            btnVar.Enabled = true;


        }
        int BarkodNo;
        void Listele()
        {
            var urunler = context.Urunler.ToList();
            dataGridView1.DataSource = urunler;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {


            if (int.TryParse(txtBarkodNo.Text, out int BarkodNo) && int.TryParse(txtMiktar.Text, out int Miktar) && decimal.TryParse(txtFiyat.Text, out decimal Fiyat) && !string.IsNullOrWhiteSpace(txtAd.Text))
            {
                BarkodNo = int.Parse(txtBarkodNo.Text);
                Urun urun = context.Urunler.SingleOrDefault(u => u.BarkodNo == BarkodNo);



                if (urun != null)
                {
                    MessageBox.Show("Eklemeye çalıştığınız ürün depoda var", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    Urun yeniUrun = new Urun();
                    yeniUrun.Adi = txtAd.Text;
                    yeniUrun.BarkodNo = int.Parse(txtBarkodNo.Text);
                    yeniUrun.Miktar = int.Parse(txtMiktar.Text);
                    yeniUrun.Fiyat = Convert.ToDecimal(txtFiyat.Text);
                    context.Urunler.Add(yeniUrun);

                    context.SaveChanges();
                    MessageBox.Show("Urun başarı ile  eklendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                }
            }
            else
            {
                MessageBox.Show("Lütfen alanları gerekli şekilde doldurun", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void btnVar_Click(object sender, EventArgs e)
        {
            BarkodNo = int.Parse(txtvarBarkod.Text);
            Urun varGuncel = context.Urunler.FirstOrDefault(u => u.BarkodNo == BarkodNo);
            varGuncel.Adi = txtvarAd.Text;
            varGuncel.Miktar = int.Parse(txtvarMiktar.Text);
            varGuncel.Fiyat = Convert.ToDecimal(txtvarFiyat.Text);

            context.SaveChanges();
            MessageBox.Show("Urun başarı ile  Güncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();


        }

        private void txtvarBarkod_TextChanged(object sender, EventArgs e)
        {
            string stringBarkod = txtvarBarkod.Text;
            BarkodNo = int.Parse(stringBarkod);
            Urun varUrun = context.Urunler.SingleOrDefault(u => u.BarkodNo == BarkodNo);
            if (varUrun != null)
            {
                txtvarAd.Text = varUrun.Adi;
                txtvarMiktar.Text = varUrun.Miktar.ToString();
                txtvarFiyat.Text = varUrun.Fiyat.ToString();
                Goster();


            }
            else
            {
                //BARKODNO YOK
            }
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu me = new Menu();
            me.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Urunn ur = new Urunn();
            ur.Show();
            this.Hide();
        }
    }
}
