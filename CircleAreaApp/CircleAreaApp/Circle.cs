using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaApp
{
    class Circle
    {
        public double radious;
        public double area;
        public double perimeter = 3.1416;
        public double diamiter;

        public double GetArea()
        {
            double r = radious*radious;
            double area = perimeter*r;
            return area;
        }

        public double GetPerimeter()
        {
            return perimeter;
        }

        public double GetDiamiter()
        {
            diamiter = radious*2;
            return diamiter;
        }
    }
}
