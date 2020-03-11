using System;
using System.Collections.Generic;
using System.Text;

namespace FileParserTask.Logic
{
    class File
    {
        public string FilePath { get; private set; }
        public File(string path)
        {
            FilePath = path;
        }
    }
}
