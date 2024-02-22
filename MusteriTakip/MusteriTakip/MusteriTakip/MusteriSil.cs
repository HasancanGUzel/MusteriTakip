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
    public partial class MusteriSil : Form
    {
        public MusteriSil()
        {
            InitializeComponent();
        }
        MusteriTakipContext context = new MusteriTakipContext();
        void Listele()
        {
            var musteri = context.Musteriler.ToList();
            dataGridView1.DataSource = musteri;
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            int ıd = int.Parse(txtId.Text);
            Musteri musteri = context.Musteriler.Find(ıd);
            context.Musteriler.Remove(musteri);
            context.SaveChanges();
            MessageBox.Show("Silme işlemi başarı ile gerçekleşti", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Listele();
            txtId.Clear();
        }

        private void MusteriSil_Load(object sender, EventArgs e)
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
            Musterii mu = new Musterii();
            mu.Show();
            this.Hide();
        }
    }
}
