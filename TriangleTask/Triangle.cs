using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace TriangleTask
{
    class Triangle
    {
        private double side1;
        private double side2;
        private double side3;
        private string name;
        private double space;

        public Triangle(string name, double a, double b, double c)
        {
            this.name = name;
            side1 = a;
            side2 = b;
            side3 = c;
        }

        public double Space()
        {
            double perimetr = (side1 + side2 + side3) / 2;
            space = Math.Sqrt(perimetr * (perimetr - side1) * (perimetr - side2) * (perimetr - side3));
            return space;
        }

        public override string ToString()
        {
            return $"[{name}]: {space} cm";
        }
    }
}
