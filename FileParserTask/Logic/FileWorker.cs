using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FileParserTask.Logic
{
    class FileWorker : File
    {
        public string Path { get; set; }
        public FileWorker(string path) : base(path)
        {
        }

        public int CountStringEnterance(string str)
        {
            var file = StringFromFile();
            var text = file;
            int count = 0;
            count = new Regex(str).Matches(text).Count;

            return count;
        }

        public void ReplaceString(string SearchStr, string ReplaceStr)
        {
            var file = StringFromFile();
            var text = file;

            text = new Regex(SearchStr).Replace(text, ReplaceStr);
            using (StreamWriter sw = new StreamWriter(FilePath, false, System.Text.Encoding.Default))
            {
                sw.Write(text);
            }
        }

        private string StringFromFile()
        {
            using (StreamReader sr = new StreamReader(FilePath))
            {

                return sr.ReadToEnd();
            }
        }
    }
}
