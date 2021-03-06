﻿using System.Collections.Generic;
using TriangleTask.Models;
using ValidationLibrary;
using TriangleTask.UI;
using System.Linq;
using System;
using log4net;
using System.Reflection;

namespace TriangleTask.TriangleApp
{
    static class Application
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static void Run()
        {
            var parser = new Parser();
            List<Triangle> t = new List<Triangle>();
            string answer;

            do
            {
                var triangle = Console.ReadLine();
                var triangleArray = parser.GetAppropriateStringArray(triangle);
                for (int i = 0; i < triangleArray.Length; i++)
                {
                    triangleArray[i] = parser.ChangeDots(triangleArray[i]);
                }

                try
                {
                    t.Add(new Triangle(triangleArray[0], Convert.ToDouble(triangleArray[1]), Convert.ToDouble(triangleArray[2]), Convert.ToDouble(triangleArray[3])));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    log.Warn(e.Message);
                    Helper.Help();
                }

                Console.WriteLine("Want more?");
                answer = Console.ReadLine().ToLower();
                answer = parser.RemoveSpaces(answer);
            } while (string.Equals(answer, "y"));

            var orderedTriangles = t.OrderByDescending(el => el.Area);
            Print.PrintTriangles(orderedTriangles);
        }
    }
}
