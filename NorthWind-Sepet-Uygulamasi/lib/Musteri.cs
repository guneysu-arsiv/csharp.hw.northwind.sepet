using System;
using System.Collections.Generic;
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
    }
}
