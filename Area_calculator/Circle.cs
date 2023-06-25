using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_calculator
{
    public class Circle : IShape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}


