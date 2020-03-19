using System.IO;
using System.Text.RegularExpressions;

namespace ValidationLibrary
{
    public static class FileValidator
    {
        public static bool CanFindFile(string filePath)
        {

            return File.Exists(filePath);
        }

        public static string[] GetAppropriateStringArrayFromFile(string filePath)
        {
            string[] array = null;

            if (CanFindFile(filePath))
            {
                string fileString;

                using (StreamReader sr = new StreamReader(filePath))
                {
                    fileString = sr.ReadToEnd();
                }

                fileString = Parser.RemoveSpaces(fileString);

                array = fileString.Split(',');
            }

            return array;
        }
    }
}
