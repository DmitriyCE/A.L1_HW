using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.L1_HW
{
    class Square : Shape
    {
        public double A { get; set; }
        public double AreaSquare { get; set; }
        public override void Area()
        {
            double area = A * A;
            AreaSquare = area;
        }
    }
}