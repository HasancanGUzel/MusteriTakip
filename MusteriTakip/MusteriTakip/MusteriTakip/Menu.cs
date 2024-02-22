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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            Musterii mu = new Musterii();
            mu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Urunn ur = new Urunn();
            ur.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sipariss sp = new Sipariss();
            sp.Show();
            this.Hide();
        }
    }
}
