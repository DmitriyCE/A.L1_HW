using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.L1_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new double[10, 3];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    switch (j)
                    {
                        case 0:
                            {
                                Circle circle = new Circle();
                                circle.Radius = i;
                                circle.Area();
                                array[i, j] = circle.AreaCirlce;
                                break;
                            }
                        case 1:
                            {
                                Square square = new Square();
                                square.A = i;
                                square.Area();
                                array[i, j] = square.AreaSquare;
                                break;
                            }
                        case 2:
                            {
                                Tringle tringle = new Tringle();
                                tringle.BaseTriangle = i;
                                tringle.HeightTriangle = i;
                                tringle.Area();
                                array[i, j] = tringle.AreaTriangle;
                                break;
                            }
                    }
                    Console.Write($"{array[i, j]}; ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
