using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Smartphone:Electronics
    {
        public string NamePhone { get; set; }
        public int ScreenDiagonal { get; set; }
        public string CPU { get; set; }

        public static bool operator <(Smartphone smart1, Smartphone smart2)
        {
            return smart1.Price < smart2.Price;
        }
        public static bool operator >(Smartphone smart1, Smartphone smart2)
        {
            return smart1.Price > smart2.Price;
        }
        public static bool operator ==(Smartphone smart1, Smartphone smart2)
        {
            return smart1.Price == smart2.Price;
        }
        public static bool operator !=(Smartphone smart1, Smartphone smart2)
        {
            return smart1.Price != smart2.Price;
        }
    }
}
