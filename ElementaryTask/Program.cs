using EnvelopeTask.Logic;
using EnvelopeTask.Validation;
using System;
using System.Linq;

namespace EnvelopeTask
{
    class Program
    {
        public delegate bool CheckDelegate(Envelope env1, Envelope env2);

        static int Main(string[] args)
        {
            double[] sides=null;
            try
            {
                sides = new DoubleArray().ToDoubleArray(args);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            if (sides != null)
            {
                Envelope env1 = new Envelope(sides[0], sides[1]);
                Envelope env2 = new Envelope(sides[2], sides[3]);
                CheckDelegate check = new CheckDelegate(CheckSizeMethods.SimpleIfChecking);
                Console.WriteLine(check(env1, env2));
            }

            return 0;
        }
    }
}
