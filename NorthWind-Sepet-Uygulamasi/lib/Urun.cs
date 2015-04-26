using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind_Sepet_Uygulamasi
{
    public class Urun
    {
        public int id { get; set; }
        public string name { get; set; }

        private int _miktar;
        public int miktar {
            get { return _miktar; }
            set
            {
                if (value < 0)
                {
                    _miktar = 0;
                }
                else
                {
                    _miktar = value;
                }
            }
        }
        public string etiket {
            get { return ToString(); }
        }
        public override string ToString()
        {
            if (_miktar == 0)
            {
                return name;
            }
            else
            {
                return String.Format("{0} [{1}]", name, _miktar.ToString());
            }
        }

    }
}
