using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.L1_HW
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public double AreaCirlce { get; set; }
        public override void Area()
        {
            double area = Math.PI * Radius * Radius;
            AreaCirlce = area;
        }
    }
}
