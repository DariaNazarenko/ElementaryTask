using log4net;
using System.Reflection;
using System.Text.RegularExpressions;

namespace FileParserTask.Logic
{
    class Counter 
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private FileWorker fileWorker;

        public Counter(string path)
        {
            fileWorker = new FileWorker(path);
        }

        public int CountStringEnterance(string str)
        {
            log.Info($"Entered CountStringEnterance with {str}");
            var file = fileWorker.Read();
            var text = file;
            int count = 0;
            count = new Regex(str).Matches(text).Count;

            return count;
        }
    }
}
