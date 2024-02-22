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
    public partial class Urunn : Form
    {
        public Urunn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunEkle ue = new UrunEkle();
            ue.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UrunSil us = new UrunSil();
            us.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UrunEkle ue = new UrunEkle();
            ue.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu me = new Menu();
            me.Show();
            this.Hide();
        }
    }
}
