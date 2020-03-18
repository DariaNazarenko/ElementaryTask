using FileParserTask.Logic;
using ValidationLibrary;
using System;
using System.IO;
using FileParserTask.FileParserApp;

namespace FileParserTask
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
