using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Brick:ConstructionMaterials
    {
        public string  Lenght { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }

        public static bool operator <(Brick brick1, Brick brick2)
        {
            return brick1.Price < brick2.Price;
        }
        public static bool operator >(Brick brick1, Brick brick2)
        {
            return brick1.Price > brick2.Price;
        }
        public static bool operator ==(Brick brick1, Brick brick2)
        {
            return brick1.Price == brick2.Price;
        }
        public static bool operator !=(Brick brick1, Brick brick2)
        {
            return brick1.Price != brick2.Price;
        }
    }
}
