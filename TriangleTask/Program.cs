using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TriangleTask.Logic;
using TriangleTask.Validation;

namespace TriangleTask
{
    class Program
    {
        static void Help()
        {
            Console.WriteLine("Use . for double values and , as delimetr.\nEnter <name>, <side1>, <side2>, <side3>.");
        }

        static void Main(string[] args)
        {
            Help();
            List<Triangle> t = new List<Triangle>();
            string answer;
            do {
                var triangle = Console.ReadLine();
                var triangleArray = new CheckInputString(triangle).GetAppropriateStringArray();
                try
                {
                    t.Add(new Triangle(triangleArray[0], Convert.ToDouble(triangleArray[1]), Convert.ToDouble(triangleArray[2]), Convert.ToDouble(triangleArray[3])));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Help();
                }
                Console.WriteLine("Want more?");
                answer = Console.ReadLine().ToLower();
            } while (answer == "y");

            var orderedTriangles = t.OrderByDescending(el => el.Area);
            foreach (var item in orderedTriangles)
            {
                Console.WriteLine(item);
            }
        }
    }
}
