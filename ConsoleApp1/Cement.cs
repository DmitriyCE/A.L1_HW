using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cement:ConstructionMaterials
    {
        public string Packing { get; set; }
        public int Mass { get; set; }

        public static bool operator <(Cement cement1, Cement cement2)
        {
            return cement1.Price < cement2.Price;
        }
        public static bool operator >(Cement cement1, Cement cement2)
        {
            return cement1.Price > cement2.Price;
        }
        public static bool operator ==(Cement cement1, Cement cement2)
        {
            return cement1.Price == cement2.Price;
        }
        public static bool operator !=(Cement cement1, Cement cement2)
        {
            return cement1.Price != cement2.Price;
        }
    }
}
