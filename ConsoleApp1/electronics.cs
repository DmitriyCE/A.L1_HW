using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Electronics:Product
    {
        public string Classification { get; set; }
        public string function { get; set; }
        Smartphone[] smartphones;
        PowerBank[] powerBanks;
    }
}
