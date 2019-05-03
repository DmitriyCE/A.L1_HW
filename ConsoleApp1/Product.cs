using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {
        public string NameOfProduct { get; set; }
        public string Manufacture { get; set; }
        public int Price { get; private set; }
        ConstructionMaterials[] ConstrMaterials;
        Electronics[] electronics;
    }
}
