using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2Gearhartr.calculator
{
    public class Circle
    {
        public double Radius { get; set; }

        public Circle() {}
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetCircumferance()
        {
            double circumferance = 2 * (Math.PI * Radius);
            return circumferance;
        }

        public double GetArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            return area;
        }
    }
}