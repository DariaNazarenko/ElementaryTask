using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidationLibrary
{
    public class FileValidator
    {
        public string FilePath { get; set; }

        public FileValidator(string path)
        {
            FilePath = path;
        }

        public bool CanFindFile(string filePath)
        {

            return System.IO.File.Exists(filePath);
        }

        public string[] GetAppropriateStringArrayFromFile(string filePath)
        {
            string[] array = null;
            const string SpacePattern = @"\s+";
            Regex regex = new Regex(SpacePattern);

            if (CanFindFile(filePath))
            {
                string fileString;

                using (StreamReader sr = new StreamReader(filePath))
                {
                    fileString = sr.ReadToEnd();
                }

                fileString = regex.Replace(fileString, string.Empty);

                array = fileString.Split(',');
            }

            return array;
        }
    }
}
