using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind_Sepet_Uygulamasi
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            Ortak.cek.musteri();
            Ortak.cek.urun();

            lstCustomers.DataSource = Ortak.musteriler;
            lstCustomers.DisplayMember = "name";
            lstCustomers.ValueMember = "id";

            lstProducts.DataSource = Ortak.urunler;
            lstProducts.DisplayMember = "name";
            lstProducts.ValueMember = "id";
        }

    }
}
