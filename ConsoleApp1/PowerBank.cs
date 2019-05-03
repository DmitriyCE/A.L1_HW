using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PowerBank:Electronics
    {
        public int InputConnector { get; set; }
        public bool battery;

        public static bool operator <(PowerBank pb1, PowerBank pb2)
        {
            return pb1.Price < pb2.Price;
        }
        public static bool operator >(PowerBank pb1, PowerBank pb2)
        {
            return pb1.Price > pb2.Price;
        }
        public static bool operator ==(PowerBank pb1, PowerBank pb2)
        {
            return pb1.Price == pb2.Price;
        }
        public static bool operator !=(PowerBank pb1, PowerBank pb2)
        {
            return pb1.Price != pb2.Price;
        }
    }
}
