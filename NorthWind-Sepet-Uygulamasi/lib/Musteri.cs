using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind_Sepet_Uygulamasi
{
    public class Musteri
    {
        public string id { get; set; }
        public string name { get; set; }
        public List<Urun> sepet = new List<Urun>();
        public string etiket
        {
            get
            {
                return ToString();
            }
        }
        public override string ToString()
        {
            if (sepet.Count() > 0)
            {
                return String.Format("{0} | {1} *[{2} Ürün]", name, id, sepet.Count().ToString());
            }
            else
            {
                return String.Format("{0} | {1}", name, id);
            }
        }

        public void sepeteAt(
            Urun urun,
            int miktar = 0)
        {

            foreach (var u in sepet)
            {
                if (u.id == urun.id)
                {
                    System.Windows.Forms.MessageBox.Show("Aynı Üründen 2 adet Sipariş Edemezsiniz.");
                    return;
                }
            }
            if (miktar == 0)
            {
                miktar = new Random().Next(1, 20);
            }
            else if (miktar < 0)
            {
                throw new Exception("Miktar 0'dan küçük olamaz");
            }

            urun.miktar = miktar;
            sepet.Add(urun);
        }

        public void siparisOlustur()
        {
            Ortak.connect();
            int EmployeeID = new Random().Next(1, 9);
            int ShipVia = new Random().Next(1, 3);
            DateTime tarih = DateTime.Now;

            string commandStringBase;
            string commandString;
            SqlCommand KOMUT;
            object OrderID;


            commandStringBase = "INSERT INTO Orders ( {0}, {1}, {2}, {3}, {4} ) ";
            commandStringBase += " VALUES (@{0}, @{1}, @{2}, @{3}, @{4} ); SELECT SCOPE_IDENTITY();";
            commandString = String.Format(
                commandStringBase,
                "CustomerID",
                "EmployeeID",
                "OrderDate",
                "RequiredDate",
                "ShipVia");

            // Orders Tablosuna Siparis Oluşturalım
            KOMUT = new SqlCommand(commandString, Ortak.conn);
            KOMUT.Parameters.AddWithValue("@CustomerID", id);
            KOMUT.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            KOMUT.Parameters.AddWithValue("@OrderDate", tarih);
            KOMUT.Parameters.AddWithValue("@RequiredDate", tarih);
            KOMUT.Parameters.AddWithValue("@ShipVia", ShipVia);
            // Oluşturduğumuz Siparişin ID'sini alalım.
            OrderID = KOMUT.ExecuteScalar();

            // Order Details tablosuna sepetimizdeki ürünleri ekleyelim.
            commandStringBase = "INSERT INTO [Order Details] ( {0}, {1}, {2}, {3}, {4} ) ";
            commandStringBase += " VALUES ( @{0}, @{1}, @{2}, @{3}, @{4} ); ";
            commandString = String.Format(commandStringBase,
                "OrderID",
                "ProductID",
                "UnitPrice",
                "Quantity",
                "Discount"
                );

            foreach (var urun in sepet)
            {
                KOMUT = new SqlCommand(commandString, Ortak.conn);
                KOMUT.Parameters.AddWithValue("@OrderID", OrderID);
                KOMUT.Parameters.AddWithValue("@ProductID", urun.id);
                KOMUT.Parameters.AddWithValue("@UnitPrice", urun.birimFiyat);
                KOMUT.Parameters.AddWithValue("@Quantity", urun.miktar);
                KOMUT.Parameters.AddWithValue("@Discount", 0);
                var f = KOMUT.ExecuteNonQuery();
            }

            // Sepeti Boşaltalım.
            sepet.Clear();
            Ortak.disconnect();
        }
    }
}
