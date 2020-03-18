using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FileParserTask.Logic
{
    class Counter 
    {
        private FileWorker fileWorker;

        public Counter(string path)
        {
            fileWorker = new FileWorker(path);
        }

        public int CountStringEnterance(string str)
        {
            var file = fileWorker.Read();
            var text = file;
            int count = 0;
            count = new Regex(str).Matches(text).Count;

            return count;
        }
    }
}
