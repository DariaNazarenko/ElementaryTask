using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileParserTask.Contracts
{
    interface IFileReaderWriter
    {
        string Read();
        void Write(string text);
    }
}
