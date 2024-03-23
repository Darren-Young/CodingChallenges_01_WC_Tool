using CommandLine;

namespace wc_tool.src
{
    public class Options
    {
        [Option('c', "byteCount", Required = false)]
        public bool DisplayByteCount { get; set; }

        [Option('l', "lineCount", Required = false)]
        public bool DisplayLineCount { get; set; }

        [Option('w', "wordCount", Required = false)]
        public bool DisplayWordCount { get; set; }

        [Option('m', "characterCount", Required = false)]
        public bool DisplayCharacterCount { get; set; }

        [Option('f', "filePath", Required = true)]
        public string FilePath { get; set; }
    }
}
