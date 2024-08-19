
using LettersCleaner;
using Newtonsoft.Json.Linq;
using Xunit;
namespace LettersCleanerTests
{
    public class LettersCleanerTests
    {
        [Theory]
        [InlineData("GrOOus", "rus")]
        [InlineData("PlanTS", "lan")]
        [InlineData("SlAvIK", "lv")]
        public void Cleaner_WithCheckTheCurrentWord_ShouldReturnOnlySmallLetters(string input, string expected)
        {
            string result = LettersCleaner.Cleaner(input);
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData("SPAGETI", "Spageti")]
        [InlineData("BABIES", "BAbies")]
        public void Cleaner_WithInvalidWord_ShouldThrowExeption(string input, string expected)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => LettersCleaner.Cleaner(input, expected));
        }

    }
}