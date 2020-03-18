using static EnvelopeTask.Logic.Delegate;
using EnvelopeTask.Models;
using EnvelopeTask.Logic;
using ValidationLibrary;
using System;

namespace EnvelopeTask.EnvelopeApp
{
    static class Application
    {
        public static void Run(string[] args)
        {
            double[] sides = Parser.GetDoubleArray(args);

            if (sides != null)
            {
                Envelope env1 = new Envelope(sides[0], sides[1]);
                Envelope env2 = new Envelope(sides[2], sides[3]);
                CheckDelegate check = new CheckDelegate(CheckSizeMethods.SimpleIfChecking);
                Console.WriteLine(check(env1, env2));
            }
            else
            {
                Console.WriteLine("Invalid input string");
            }
        }
    }
}
