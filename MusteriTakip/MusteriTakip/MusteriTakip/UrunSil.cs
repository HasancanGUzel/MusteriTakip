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
    public partial class UrunSil : Form
    {
        public UrunSil()
        {
            InitializeComponent();
        }

        MusteriTakipContext context = new MusteriTakipContext();
        void Listele()
        {
            var urunler = context.Urunler.ToList();
            dataGridView1.DataSource = urunler;
        }
        private void UrunSil_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                

                int ıd = int.Parse(txtId.Text);
                Urun urun = context.Urunler.Find(ıd);
                if (urun != null)
                {
                    context.Urunler.Remove(urun);
                    context.SaveChanges();
                    MessageBox.Show("Silme işlemi başarı ile gerçekleşti", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                    txtId.Clear();
                }
                else
                {

                    MessageBox.Show("Yanlış Id Numarası", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Id Girilmedi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
            Urunn ur = new Urunn();
            ur.Show();
            this.Hide();
        }
    }
}
