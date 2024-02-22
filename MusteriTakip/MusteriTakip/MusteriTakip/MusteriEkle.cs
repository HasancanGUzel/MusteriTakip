using Microsoft.EntityFrameworkCore;
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

namespace MusteriTakip
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }
        MusteriTakipContext context = new MusteriTakipContext();


        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            if (double.TryParse(textTcNo.Text, out double TCKN) && double.TryParse(textTelNo.Text, out double Telefon) && !string.IsNullOrWhiteSpace(textAd.Text) && !string.IsNullOrWhiteSpace(textSoyad.Text) && !string.IsNullOrWhiteSpace(txtadres.Text)) 
            {
                musteri.Ad = textAd.Text;
                musteri.Soyad = textSoyad.Text;
                musteri.Telefon = double.Parse(textTelNo.Text);
                musteri.TCKN = double.Parse(textTcNo.Text);
                musteri.Adres = txtadres.Text;

                context.Musteriler.Add(musteri);

                context.SaveChanges();
                MessageBox.Show("müşteri eklendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Lütfen alanları gerekli şekilde doldurun Telefon numarası veya TC KİMLİK NO alanına sayısal değer girin.");
                return; 
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musterii mu= new Musterii();
            mu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu me = new Menu();
            me.Show();
            this.Hide();
        }
    }
}
