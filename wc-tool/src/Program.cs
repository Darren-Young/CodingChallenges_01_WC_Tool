using CommandLine;
using wc_tool.src;

Parser.Default.ParseArguments<Options>(args: args)
    .WithParsed<Options>(option =>
    {
        var filePath = option.FilePath;

        if (option.DisplayByteCount)
        {
            var count = Convert.ToInt32(FileProcessor.GetByteCount(filePath));
            Console.WriteLine($"{count} {filePath}");
        }
        else if (option.DisplayLineCount)
        {
            var count = FileProcessor.GetLineCount(filePath);
            Console.WriteLine($"{count} {filePath}");
        }
        else if (option.DisplayWordCount)
        {
            var count = FileProcessor.GetWordCount(filePath);
            Console.WriteLine($"{count} {filePath}");
        }
        else if (option.DisplayCharacterCount)
        {
            var count = FileProcessor.GetCharacterCount(filePath);
            Console.WriteLine($"{count} {filePath}");
        }
        else
        {
            var byteCount = FileProcessor.GetByteCount(filePath);
            var lineCount = FileProcessor.GetLineCount(filePath);
            var wordCount = FileProcessor.GetWordCount(filePath);
            Console.WriteLine($"{byteCount} {lineCount} {wordCount} {filePath}");
        }

        Console.ReadKey();
    });
