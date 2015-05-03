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
            label1.Text = "Sepete Ürün Eklemek İçin, Ürünler Listesine çift tıklayın.\n\n";
            label1.Text += "Seçili Müşteri sipariş vermeden veya iptal etmeden yeni müşteri seçilemez.";

            uiInitCustomers();
            uiInitProducts();
        }

        private void uiInitProducts()
        {
            Ortak.cek.urun();
            lstProducts.DataSource = Ortak.urunler;
            lstProducts.DisplayMember = "etiket";
            lstProducts.ValueMember = "id";
        }

        private void uiInitCustomers()
        {
            Ortak.cek.musteri();
            lstCustomers.DataSource = Ortak.musteriler;
            lstCustomers.DisplayMember = "etiket";
            lstCustomers.ValueMember = "id";
        }

        private void lstProducts_DoubleClick(object sender, EventArgs e)
        {
            Musteri musteri = (Musteri)lstCustomers.SelectedItem;
            Urun urun = (Urun)lstProducts.SelectedItem;

            if (musteri != null && urun != null)
            {
                musteri.sepeteAt(urun);
            }
            uiRefreshCustomers();
            uiRefreshProducts();
            uiRefreshSepet();
        }

        private void uiRefreshSepet()
        {
            lstSepet.DataSource = null;
            lstSepet.Items.Clear();
            lstSepet.DataSource = Ortak.musteriler[lstCustomers.SelectedIndex].sepet;
        }

        private void uiRefreshCustomers()
        {
            lstCustomers.DataSource = null;
            lstCustomers.Items.Clear();
            lstCustomers.DataSource = Ortak.musteriler;
            lstCustomers.DisplayMember = "etiket";
            lstCustomers.ValueMember = "id";
            lstCustomers.SetSelected(lstCustomers.SelectedIndex, true);
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
            Musteri musteri = (Musteri)lstCustomers.SelectedItem;
            musteri.siparisOlustur();
            uiInitProducts();
            uiRefreshCustomers();
            uiRefreshSepet();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Ortak.musteriler[lstCustomers.SelectedIndex].sepet.Clear();
            uiRefreshCustomers();
            uiRefreshSepet();
            lstCustomers.Enabled = true;
        }




    }
}
