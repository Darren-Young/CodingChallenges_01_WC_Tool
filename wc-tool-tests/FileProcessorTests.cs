using wc_tool.src;

namespace ws_tool_tests
{
    public class Tests
    {
        [Test]
        public void GetByteCount_IfInvalidFile_ThrowsException()
        {
            // Then 
            Assert.Throws<FileNotFoundException>(() => FileProcessor.GetByteCount("foo.txt"));
        }

        [Test]
        public void GetByteCount_ForTestFile_ReturnsCorrectByteCount()
        {
            // Given
            const long expectedByteCount = 342182;

            // When
            var byteCount = FileProcessor.GetByteCount("test.txt");

            // Then
            Assert.That(byteCount, Is.EqualTo(expectedByteCount));
        }

        [Test]
        public void GetLineCount_IfInvalidFile_ThrowsException()
        {
            Assert.Throws<FileNotFoundException>(() => FileProcessor.GetLineCount("foo.txt"));
        }

        [Test]
        public void GetLineCount_ForTestFile_ReturnsCorrectLineCount()
        {
            // Given
            const int expectedLineCount = 7142;

            // When
            var lineCount = FileProcessor.GetLineCount("test.txt");

            // Then
            Assert.That(lineCount, Is.EqualTo(expectedLineCount));
        }

        [Test]  
        public void GetWordCount_ForTestFile_ReturnsCorrectWordCount()
        {
            // Given
            const int expectedWordCount = 58164;

            // When
            var wordCount = FileProcessor.GetWordCount("test.txt");

            // Then
            Assert.That(wordCount, Is.EqualTo(expectedWordCount));
        }

        [Test]
        public void GetWordCount_IfInvalidFile_ThrowsException()
        {
            Assert.Throws<FileNotFoundException>(() => FileProcessor.GetWordCount("foo.txt"));
        }

        [Test]
        public void GetCharacterCount_IfInvalidFile_ThrowsException()
        {
            Assert.Throws<FileNotFoundException>(() => FileProcessor.GetCharacterCount("foo.txt"));
        }

        [Test]
        public void GetCharacterCount_ForTestFile_ReturnsCorrectCharacterCount()
        {
            // Given
            const int expectedWordCount = 325001;

            // When
            var characterCount = FileProcessor.GetCharacterCount("test.txt");

            // Then
            Assert.That(characterCount, Is.EqualTo(expectedWordCount));
        }
    }
}