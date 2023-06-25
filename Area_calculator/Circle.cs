using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_calculator
{
    public class Circle : IShape
    {
        private double _radius;
        Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateArea()
        {
            double area = Math.PI * Math.Pow(_radius, 2);
            return area;
        }
    }
}


