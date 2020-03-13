using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileParserTask.Validation
{
    class Validate
    {
        public bool CanFindFile(string filePath)
        {
            return System.IO.File.Exists(filePath);
        }
    }
}
