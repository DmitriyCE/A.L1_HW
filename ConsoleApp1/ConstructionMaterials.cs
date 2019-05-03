using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ConstructionMaterials : Product
    {
        public string Classification { get; set; }
        public string function { get; set; }
        Brick[] bricks;
        Cement[] cements;
    }
}
