using System;
using TriangleTask.Contracts;

namespace TriangleTask.Models
{
    class Triangle : IGeometrical
    {
        private double side1;
        private double side2;
        private double side3;
        private string name;
        
        public double Perimetr { get => side1 + side2 + side3; }
        public double Area { get => Math.Sqrt(Perimetr / 2 * (Perimetr / 2 - side1) * (Perimetr / 2 - side2) * (Perimetr / 2 - side3)); }

        public Triangle(string name, double side1, double side2, double side3)
        {
            this.name = name;
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override string ToString()
        {
            return $"[{name}]: {Area} cm";
        }
    }
}
