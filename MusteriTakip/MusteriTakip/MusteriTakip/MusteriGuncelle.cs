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
    public partial class MusteriGuncelle : Form
    {
        public MusteriGuncelle()
        {
            InitializeComponent();
        }
        MusteriTakipContext context = new MusteriTakipContext();
        void Goster()
        {
            txtAd.Enabled = true;
            txtSoyad.Enabled = true;
            txtAdres.Enabled = true;
            txtTelNo.Enabled = true;
            txtTcNo.Enabled = true;
            btnGuncelle.Enabled = true;

        }
        void Listele()
        {
            var musteri = context.Musteriler.ToList();
            dataGridView1.DataSource = musteri;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            int secilenId = int.Parse(txtId.Text);
            Musteri musteri = context.Musteriler.Find(secilenId);
            txtAd.Text = musteri.Ad;
            txtSoyad.Text = musteri.Soyad;
            txtAdres.Text = musteri.Adres;
            txtTelNo.Text = musteri.Telefon.ToString();
            txtTcNo.Text = musteri.TCKN.ToString();
            Goster();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTelNo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtTcNo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Goster();
        }

        private void MusteriGuncelle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int secilenId = int.Parse(txtId.Text);
            Musteri musteri = context.Musteriler.FirstOrDefault(u => u.Id == secilenId);

            if (double.TryParse(txtTcNo.Text, out double TCKN) && double.TryParse(txtTelNo.Text, out double Telefon) && !string.IsNullOrWhiteSpace(txtAd.Text) && !string.IsNullOrWhiteSpace(txtSoyad.Text) && !string.IsNullOrWhiteSpace(txtAdres.Text))
            {
                musteri.Ad = txtAd.Text;
                musteri.Soyad = txtSoyad.Text;
                musteri.Adres = txtAdres.Text;
                musteri.Telefon = double.Parse(txtTelNo.Text);
                musteri.TCKN = double.Parse(txtTcNo.Text);
            }

            else
            {
                MessageBox.Show("Lütfen alanları gerekli şekilde doldurun Telefon numarası veya TC KİMLİK NO alanına sayısal değer girin.");
                return; 
            }

            context.SaveChanges();
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
            Musterii mu = new Musterii();
            mu.Show();
            this.Hide();
        }
    }
}
