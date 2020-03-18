using EnvelopeTask.EnvelopeApp;
using System;

namespace EnvelopeTask
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Application.Run(args);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
