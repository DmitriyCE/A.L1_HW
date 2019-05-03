using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.L1_HW
{
    class Tringle:Shape
    {
        public double BaseTriangle { get; set; }
        public double HeightTriangle { get; set; }
        public double AreaTriangle { get; set; }
        public override void Area()
        {
            double area = 0.5 * BaseTriangle * HeightTriangle;
            AreaTriangle = area;
        }
    }
}
