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

        public override string ToString()
        {
            return name;
        }
    }
}
