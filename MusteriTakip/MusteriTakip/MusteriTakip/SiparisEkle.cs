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
    public partial class SiparisEkle : Form
    {
        int _siparisId = 0;
        bool _guncellenecek = false;
        public SiparisEkle(int siparisId)
        {
            _siparisId = siparisId; //Sipariss ekranından datagridviewdan seçili olan siparişin ıd si

            InitializeComponent();

        }

        void Clear()
        {

            txtMiktar.Clear();
            txtFiyat.Clear();
        }


        MusteriTakipContext context = new MusteriTakipContext();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMusteriId.Text, out int Id))
            {
                int musteriId = int.Parse(txtMusteriId.Text);
                Musteri? musteri = context.Musteriler.Find(musteriId);

                if (musteri != null)
                {
                    txtMusteriId.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Böyle Bir müşteri Bulunamadı ", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                int secilenUrun = (int)cmUrunler.SelectedValue;
                var urun = context.Urunler.Find(secilenUrun);

                if (int.TryParse(txtMiktar.Text, out int miktar) && decimal.TryParse(txtFiyat.Text, out decimal fiyat)) //miktar ve fiyat sayıdan hariç girilmesin dedim
                {


                    urun.Miktar -= int.Parse(txtMiktar.Text);

                    if (urun.Miktar < 0)
                    {
                        MessageBox.Show("Stokta yeteri kadar ürün yok");
                        urun.Miktar += int.Parse(txtMiktar.Text);
                    }
                    else
                    {
                        ListViewItem ekle = new ListViewItem(urun.Adi);
                        ekle.SubItems.Add(txtMiktar.Text);
                        ekle.SubItems.Add(txtFiyat.Text);
                        ekle.SubItems.Add(txtAciklama.Text);
                        ekle.Tag = secilenUrun;
                        listView1.Items.Add(ekle);
                    }

                }
                else
                {
                    MessageBox.Show("Miktar veya fiyat geçersiz. Lütfen sayısal değerler girin.");
                    return;
                }

                lblMiktar.Text = urun.Miktar.ToString();

                txtAciklama.Enabled = false;

                Clear();
            }
            else
            {
                MessageBox.Show("Id geçersiz. Lütfen sayısal değer girin.");
                return;
            }









        }



        private void SiparisEkle_Load(object sender, EventArgs e)
        {

            var urunler = context.Urunler.Select(u => new { u.Id, u.Adi }).ToList();
            cmUrunler.DataSource = null;
            cmUrunler.Items.Clear();
            cmUrunler.DataSource = urunler;
            cmUrunler.DisplayMember = "Adi";
            cmUrunler.ValueMember = "Id";


            if (_siparisId > 0)
            {
                Siparis siparis = context.Siparisler.Include(s => s.SiparisDetay).FirstOrDefault(s => s.Id == _siparisId);
                if (siparis != null)
                {
                    txtMusteriId.Text = siparis.MusteriId.ToString();
                    txtAciklama.Text = siparis.Aciklama;
                    _guncellenecek = true;
                    txtMusteriId.Enabled = false;

                    var siprUrun = context.SiparisDetaylar.Where(sd => sd.SiparisId == _siparisId).Include(sd => sd.Urun);
                    foreach (var siparisDetay in siprUrun)
                    {
                        if (siparisDetay != null && siparisDetay.Urun != null)
                        {
                            ListViewItem item = new ListViewItem(new string[]
                        {
                                siparisDetay.Urun.Adi,
                                siparisDetay.Miktar.ToString(),
                                siparisDetay.BirimFiyat.ToString(),
                                siparis.Aciklama,
                                siparisDetay.Id.ToString()



                         });
                            item.Tag = siparisDetay.UrunId;

                            listView1.Items.Add(item);

                        }
                    }
                }
            }



        }



        private void cmUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmUrunler.SelectedValue != null && cmUrunler.SelectedValue is int)
            {
                int secilenUrun = (int)cmUrunler.SelectedValue;
                var urun = context.Urunler.Find(secilenUrun);


                lblMiktar.Text = urun.Miktar.ToString();
                txtFiyat.Text = urun.Fiyat.ToString();


            }





        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu me = new Menu();
            me.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sipariss sip = new Sipariss();
            sip.Show();
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = listView1.SelectedItems[0];


                string silinenUrun = selectedRow.SubItems[0].Text;
                int silinenMiktar = int.Parse(selectedRow.SubItems[1].Text);
                int silinenDetayId = int.Parse(selectedRow.SubItems[4].Text);

                int SilinenUrunStokMiktarı = context.Urunler
                  .Where(u => u.Adi == silinenUrun)
                  .Select(u => u.Miktar)
                  .FirstOrDefault();

                int urunStok = silinenMiktar + SilinenUrunStokMiktarı;

                lblMiktar.Text = urunStok.ToString();

                var urun = context.Urunler.FirstOrDefault(u => u.Adi == silinenUrun);

                if (urun != null)
                {
                    urun.Miktar = urunStok;
                    context.SaveChanges();
                }

                var silinenSiparisDetay = context.SiparisDetaylar.FirstOrDefault(s => s.Id == silinenDetayId);
                context.SiparisDetaylar.Remove(silinenSiparisDetay);
                context.SaveChangesAsync();

                listView1.Items.Remove(selectedRow);

            }
            else
            {
                MessageBox.Show("Lütfen silme işlemi için tablodan kayıt seçiniz...", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_guncellenecek)
            {
                using (var context = new MusteriTakipContext())
                {

                    int guncellenecekSiparisID = _siparisId;

                    var guncellenecekSiparis = context.Siparisler.FirstOrDefault(s => s.Id == guncellenecekSiparisID);

                    if (guncellenecekSiparis != null)
                    {

                        guncellenecekSiparis.Tarih = DateTime.Now;
                        guncellenecekSiparis.MusteriId = int.Parse(txtMusteriId.Text);
                        guncellenecekSiparis.Aciklama = txtAciklama.Text;
                        context.SaveChanges();
                    }

                    //siparisdetaydaki verileri önce siliyorum sonra aşşağıda tekrar ekliyorum
                    var silinecekSiparisDetaylar = context.SiparisDetaylar.Where(sd => sd.SiparisId == guncellenecekSiparisID);
                    context.SiparisDetaylar.RemoveRange(silinecekSiparisDetaylar);
                    context.SaveChanges();


                    foreach (ListViewItem item in listView1.Items)
                    {

                        int urunId = (int)item.Tag;

                        var urun = context.Urunler.Find(urunId);

                        var yeniSiparisDetay = new SiparisDetay
                        {

                            UrunId = urunId,
                            Miktar = Convert.ToInt32(item.SubItems[1].Text),
                            BirimFiyat = Convert.ToDecimal(item.SubItems[2].Text),
                            SiparisId = guncellenecekSiparisID,
                            ToplamFiyat = Convert.ToInt32(item.SubItems[1].Text) * Convert.ToDecimal(item.SubItems[2].Text)

                        };
                        context.SiparisDetaylar.Add(yeniSiparisDetay);

                    }
                    context.SaveChanges();
                    MessageBox.Show("Siparis başarı ile  Güncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {


                var yeniSiparis = new Siparis
                {
                    Tarih = DateTime.Now,
                    MusteriId = int.Parse(txtMusteriId.Text),
                    Aciklama = txtAciklama.Text,

                };

                context.Siparisler.Add(yeniSiparis);
                context.SaveChanges();


                int eklenenSiparisID = yeniSiparis.Id;


                foreach (ListViewItem item in listView1.Items)
                {
                    int urunId = (int)item.Tag;
                    var urun = context.Urunler.Find(urunId);

                    var yeniSiparisDetay = new SiparisDetay
                    {
                        UrunId = urunId,
                        Miktar = Convert.ToInt32(item.SubItems[1].Text),
                        BirimFiyat = Convert.ToDecimal(item.SubItems[2].Text),
                        SiparisId = eklenenSiparisID,
                        ToplamFiyat = Convert.ToInt32(item.SubItems[1].Text) * Convert.ToDecimal(item.SubItems[2].Text)




                    };
                    context.SiparisDetaylar.Add(yeniSiparisDetay);

                }
                context.SaveChanges();

                MessageBox.Show("Siparis başarı ile  eklendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);







            }
        }
    }
}
