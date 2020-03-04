using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TriangleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> t = new List<Triangle>();
            string answer;
            do {
                var triangle = Console.ReadLine();
                var triangleArray = new CheckInputString().GetAppropriateStringArray(triangle);
                try
                {
                    t.Add(new Triangle(triangleArray[0], Convert.ToInt32(triangleArray[1]), Convert.ToDouble(triangleArray[2]), Convert.ToDouble(triangleArray[3])));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("More?");
                answer = Console.ReadLine();
            } while (answer == "y");

            var orderedTriangles = t.OrderByDescending(el => el.Space(), new SpecialComparer());
            foreach (var item in orderedTriangles)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
