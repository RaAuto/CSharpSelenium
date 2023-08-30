using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept.MathConcept
{
    public class Area
    {
        public static double CircleArea(int r)
        {
            double area = 3.14 * r * r;
            return area;
        }

        public static double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }

        public static double AreaoFSquare(double a)
        {
            return a*a;
        }

        public  double AreaofTriangle(double c, double d)
        {
            return c * d / 2;
        }


        public static void Main4(string[] args)
        {
            double result = Area.CircleArea(10);
            Console.WriteLine(result);

            double result1 = Area.AreaoFSquare(20);
            Console.WriteLine("Area of Square:"+ result1);

            Area a=new Area();
            double result2 = a.AreaofTriangle(25,1);
            Console.WriteLine("Area of Triangle:" + result2);
        }
    }
}
