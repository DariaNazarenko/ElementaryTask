using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using TriangleTask.Contracts;

namespace TriangleTask.Logic
{
    class Triangle : IGeometrical
    {
        private double side1;
        private double side2;
        private double side3;
        private string name;
        
        public double Perimetr { get => side1 + side2 + side3; }
        public double Area { get => Math.Sqrt(Perimetr / 2 * (Perimetr / 2 - side1) * (Perimetr / 2 - side2) * (Perimetr / 2 - side3)); }

        public Triangle(string name, double a, double b, double c)
        {
            this.name = name;
            side1 = a;
            side2 = b;
            side3 = c;
        }

        public override string ToString()
        {
            return $"[{name}]: {Area} cm";
        }
    }
}
