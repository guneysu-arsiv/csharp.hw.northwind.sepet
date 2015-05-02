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
        protected int OrderID { get; set; }
        public string name { get; set; }
        public List<Urun> sepet = new List<Urun>();
        public string etiket {
            get
            {
                return ToString();
            }
        }
        public override string ToString()
        {
            if (sepet.Count() > 0)
            {
                return String.Format("{0} [*]", name);
            }
            else
            {
                return name;
            }
        }

        public Musteri()
        {
            OrderID = -1;
        }
        public void siparisOlustur()
        {
            Ortak.connect();
            SqlCommand KOMUT = new SqlCommand("SELECT * FROM Orders; SELECT SCOPE_IDENTITY();", Ortak.conn);
            var f = ((int)KOMUT.ExecuteScalar()).ToString();
            System.Windows.Forms.MessageBox.Show(f);
            System.Windows.Forms.MessageBox.Show(DateTime.Now.ToString());
            Ortak.disconnect();

        }
    }
}
