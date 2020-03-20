using TriangleTask.UI;
using LoggerLibrary;
using TriangleTask.TriangleApp;

namespace TriangleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Initialize();
            Helper.Help();

            Application.Run();
        }
    }
}
