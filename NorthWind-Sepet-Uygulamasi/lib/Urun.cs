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
        public int miktar
        {
            get { return miktar; }

            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    miktar = value;
                }

            }
        }

        public override string ToString()
        {
            return name;
        }

        public Urun()
        {
            miktar = 0;
        }
    }
}
