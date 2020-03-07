using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FileParserTask
{
    class FileWorker : File
    {
        public FileWorker(string path) : base(path)
        {
        }

        public int CountStringEnterance(string str)
        {
            var file = StringFromFile();
            var text = file.Result;
            int count = 0;
            try
            {
                count = new Regex(str).Matches(text).Count;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return count;
        }

        public async void ReplaceString(string SearchStr, string ReplaceStr)
        {
            var file = StringFromFile();
            var text = file.Result;
            try
            {
                text = new Regex(SearchStr).Replace(text, ReplaceStr);
                using (StreamWriter sw = new StreamWriter(FilePath, false, System.Text.Encoding.Default))
                {
                    await sw.WriteAsync(text);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private async Task<string> StringFromFile()
        {
            using (StreamReader sr = new StreamReader(FilePath))
            {
                return await sr.ReadToEndAsync();
            }
        }
    }
}
