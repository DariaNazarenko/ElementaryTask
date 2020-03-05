using System;
using System.Collections.Generic;
using System.Text;

namespace FileParserTask
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
