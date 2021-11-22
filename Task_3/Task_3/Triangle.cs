using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class Triangle: Figure
    {
        public override double S { get; set; }

        public override double Area()
        {
            S = 0.5 * a * h;
            Console.WriteLine(S);
            return S;
        }

        double a;
        double h;

        public Triangle(double side, double height)
        {
            a = side;
            h = height;
        }  
    }
}
