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
    public partial class Sipariss : Form
    {
        public Sipariss()
        {
            InitializeComponent();
        }

        MusteriTakipContext context = new MusteriTakipContext();



       

        private void Sipariss_Load(object sender, EventArgs e)
        {
            var siparisListesi = context.Siparisler.Include(s => s.Musteri).ToList();


            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = siparisListesi;

            dataGridView1.DataSource = bindingSource;

            
            dataGridView1.Columns["Musteri"].Visible = false; 
            dataGridView1.Columns["MusteriId"].Visible = false; 

            DataGridViewColumn musteriAdiColumn = new DataGridViewTextBoxColumn();
            musteriAdiColumn.HeaderText = "Müşteri Adı";
            musteriAdiColumn.Name = "MusteriAdi";
            dataGridView1.Columns.Add(musteriAdiColumn);

           
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                int musteriId = (int)dataGridView1.Rows[i].Cells["MusteriId"].Value;
                var musteriAdi = context.Musteriler.Where(m => m.Id == musteriId).Select(m => m.Ad).FirstOrDefault();
                dataGridView1.Rows[i].Cells["MusteriAdi"].Value = musteriAdi;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu me = new Menu();
            me.Show();
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SiparisEkle se = new SiparisEkle(-1);
            se.Show();
            this.Hide();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                int siparisId = (int)dataGridView1.Rows[selectedRowIndex].Cells["Id"].Value;
                SiparisEkle se = new SiparisEkle(siparisId);
                se.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen Güncellemek istediğiniz bir sipariş seçin.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Seçili siparişi silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                    int siparisId = (int)dataGridView1.Rows[selectedRowIndex].Cells["Id"].Value;

                    // Veritabanından ilgili siparişi bul
                    var siparis = context.Siparisler
                     .Include(s => s.SiparisDetay)
                     .FirstOrDefault(s => s.Id == siparisId);

                    if (siparis != null)
                    {
                        List<Urun> urunlerToUpdate = new List<Urun>();
                        foreach (var siparisDetay in siparis.SiparisDetay)
                        {
                            int urunId = siparisDetay.UrunId;
                            int miktar = siparisDetay.Miktar;

                            var urun = context.Urunler.FirstOrDefault(u => u.Id == urunId);

                            if (urun != null)
                            {                             
                                urun.Miktar += miktar;
                                urunlerToUpdate.Add(urun);

                            }
                        }

                        context.SaveChanges();

                        context.SiparisDetaylar.RemoveRange(siparis.SiparisDetay);
                        context.Siparisler.Remove(siparis);

                        context.SaveChanges();
                     
                        dataGridView1.Rows.RemoveAt(selectedRowIndex);
                    }

                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir sipariş seçin.");
            }

        }
    }
}
