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
            lstCustomers.DisplayMember = "etiket";
            lstCustomers.ValueMember = "id";

            lstProducts.DataSource = Ortak.urunler;
            lstProducts.DisplayMember = "etiket";
            lstProducts.ValueMember = "id";

            Ortak.urunler[0].miktar = -1;
            Ortak.musteriler[0].siparisOlustur();
        }

        private void lstProducts_DoubleClick(object sender, EventArgs e)
        {
            int mindex = lstCustomers.SelectedIndex;
            int uindex = lstProducts.SelectedIndex;

            if (uindex > -1 && mindex > -1)
            {
                Ortak.sepeteAt(
                    musteriIndex: lstCustomers.SelectedIndex,
                    urunIndex: lstProducts.SelectedIndex
                    );
            }

            lstCustomers.DataSource = null;
            lstCustomers.Items.Clear();
            lstCustomers.DataSource = Ortak.musteriler;
            lstCustomers.DisplayMember = "etiket";
            lstCustomers.ValueMember = "id";
            lstCustomers.SetSelected(mindex, true);

            uiRefreshProducts();
            lstSepet.DataSource = null;
            lstSepet.Items.Clear();
            lstSepet.DataSource = Ortak.musteriler[lstCustomers.SelectedIndex].sepet;


        }

        private void uiRefreshProducts()
        {
            lstProducts.DataSource = null;
            lstProducts.Items.Clear();
            lstProducts.DataSource = Ortak.urunler;
            lstProducts.DisplayMember = "name";
            lstProducts.ValueMember = "id";

        }

        private void lstCustomers_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                lstSepet.DataSource = ((Musteri)lstCustomers.SelectedItem).sepet;
                lstSepet.DisplayMember = "etiket";
                lstSepet.ValueMember = "id";

            }
            catch (Exception)
            {
                
            }
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCustomers.Enabled = false;
        }

        private void btnSiparisOlustur_Click(object sender, EventArgs e)
        {
            lstCustomers.Enabled = true;
            Ortak.cek.urun();
            uiRefreshProducts();
        }

    }
}
