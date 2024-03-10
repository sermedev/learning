using StringUtils;
using Moq;
using Microsoft.Extensions.Logging;

namespace StringUtilsTest
{
    public class StringOperationTest
    {
        [Fact(Skip = "This test is not valid because XXX, Ticket YYYY")]
        public void ConcatenateStrings()
        {
            // Arrange
            var stringOperation = new StringOperations();
            var input1 = "Hi";
            var input2 = "there";
            var expected = "Hi there";

            // Act
            var result = stringOperation.ConcatenateStrings(input1, input2);

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("oro", true)]
        [InlineData("plata", false)]
        public void IsPalindrome(string input, bool expected)
        {
            // Arrange
            var stringOperation = new StringOperations();

            // Act
            var result = stringOperation.IsPalindrome(input);

            // Assert
            if(expected)
            {
                Assert.True(result);
            }
            else
            {
                Assert.False(result);
            }
        }

        [Fact]
        public void RemoveWhitespace()
        {
            // Arrange
            var stringOperation = new StringOperations();
            var input = "Hola me llamo Pedro";
            var expectedSubstring = " ";

            // Act
            var result = stringOperation.RemoveWhitespace(input);

            // Assert
            Assert.DoesNotContain(expectedSubstring, result);
        }

        [Fact]
        public void QuantintyInWords()
        {
            // Arrange
            var stringOperation = new StringOperations();
            var input = "dog";
            var quantity = 5;
            var expectedStartString = "five";
            var expectedSubstring = "dog";

            // Act
            var result = stringOperation.QuantintyInWords(input, quantity);

            // Assert
            Assert.StartsWith(expectedStartString, result);
            Assert.Contains(expectedSubstring, result);
        }

        [Fact]
        public void GetStringLength_Exception()
        {
            // Arrange
            var stringOperation = new StringOperations();

            // Assert
            Assert.ThrowsAny<ArgumentNullException>(() => stringOperation.GetStringLength(null));
        }

        [Fact]
        public void GetStringLength()
        {
            // Arrange
            var stringOperation = new StringOperations();
            var input = "dogs";

            // Act
            var result = stringOperation.GetStringLength(input);

            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void TruncateString_ReturnsOriginalString_WhenInputIsNullOrEmpty()
        {
            // Arrange
            var stringOperation = new StringOperations();
            var input = "";
            var maxLength = 10;
            var expected = input;

            // Act
            var result = stringOperation.TruncateString(input, maxLength);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TruncateString_ReturnsOriginalString_WhenMaxLengthIsGreaterThanOrEqualToInputLength()
        {
            // Arrange
            var stringOperation = new StringOperations();
            var input = "Hello, world!";
            var maxLength = input.Length + 5;
            var expected = input;

            // Act
            var result = stringOperation.TruncateString(input, maxLength);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TruncateString_TruncatesString_WhenMaxLengthIsLessThanInputLength()
        {
            // Arrange
            var stringOperation = new StringOperations();
            var input = "Hello, world!";
            var maxLength = 5;
            var expected = "Hello";

            // Act
            var result = stringOperation.TruncateString(input, maxLength);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("V", 5)]
        [InlineData("III", 3)]
        [InlineData("X", 10)]
        public void FromRomanToNumber(string romanNumber, int expected)
        {
            // Arrange
            var stringOperation = new StringOperations();

            // Act
            var result = stringOperation.FromRomanToNumber(romanNumber);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CountOccurrences()
        {
            // Arrange
            var mockLogger = new Mock<ILogger<StringOperations>>();
            var stringOperation = new StringOperations(mockLogger.Object);
            var input = "Hello, world!";
            var character = 'l';
            var expectedOcurrences = 3;

            // Act
            var result = stringOperation.CountOccurrences(input, character);

            // Assert
            Assert.Equal(expectedOcurrences, result);
        }

        [Fact]
        public void ReadFile()
        {
            // Arrange
            var stringOperation = new StringOperations();
            var fileName = "file.txt";
            var expected = "Reading file";

            var mockFileReader = new Mock<IFileReaderConector>(); 
            mockFileReader.Setup(p => p.ReadString(It.IsAny<string>())).Returns(expected);

            // Act
            var result = stringOperation.ReadFile(mockFileReader.Object, fileName);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
