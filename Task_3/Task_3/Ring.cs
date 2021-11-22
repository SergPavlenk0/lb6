using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class Ring: Figure
    {
        public override double S { get; set; }
        public override double Area()
        {
            S = 3.14 * r * r;
            Console.WriteLine(S);
            return S;
        }

        double r;
        public Ring(double radius)
        {
            r = radius;
        }
             
    }
}
