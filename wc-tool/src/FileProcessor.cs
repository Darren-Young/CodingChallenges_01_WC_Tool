using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wc_tool.src
{
    public static class FileProcessor
    {
        public static long GetByteCount(string filePath)
        {
            var file = new FileInfo(filePath);
            return file.Length;
        }

        public static int GetLineCount(string filePath)
        {
            var lines = File.ReadAllLines(filePath, Encoding.ASCII);
            return lines.Length;
        }

        public static int GetWordCount(string filePath)
        {
            var text = File.ReadAllText(filePath);
            var delimiters = new char[] { ' ', '\r', '\n', '\t' };
            return text?.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length ?? 0;
        }

        public static int GetCharacterCount(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            return lines.Sum(x => x.Length);
        }
    }
}
