using FileParserTask.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FileParserTask.Logic
{
    class FileWorker : IFileReaderWriter
    {
        public string FilePath { get; private set; }
        public FileWorker(string path)
        {
            FilePath = path;
        }

        public string Read()
        {
            using (StreamReader sr = new StreamReader(FilePath))
            {

                return sr.ReadToEnd();
            }
        }

        public void Write(string text)
        {
            using (StreamWriter sw = new StreamWriter(FilePath, false, System.Text.Encoding.Default))
            {
                sw.Write(text);
            }
        }
    }
}
