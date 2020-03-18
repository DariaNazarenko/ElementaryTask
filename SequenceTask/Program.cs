using SequenceTask.SequenceApp;
using System;

namespace SequenceTask
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
