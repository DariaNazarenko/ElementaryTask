using System.Text.RegularExpressions;

namespace FileParserTask.Logic
{
    class Replacer
    {
        private FileWorker fileWorker;

        public Replacer(string path)
        {
            fileWorker = new FileWorker(path);
        }

        public void ReplaceString(string SearchStr, string ReplaceStr)
        {
            var file = fileWorker.Read();
            var text = file;

            text = new Regex(SearchStr).Replace(text, ReplaceStr);
            fileWorker.Write(text);
        }
    }
}
