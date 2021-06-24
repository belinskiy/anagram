using System;
using Xunit;
using StrRev;

namespace StrRev
{
    public class UnitTest1
    {
        [Fact]
        public void Reverse_ShouldReturnNull_IfWordIsNull()
        {
            // arrange
            var anagram = new Anagram();

            // act 
            string result = anagram.ReverseWord(null);

            // assert
            Assert.Null(result);
        }
        [Theory]
        [InlineData("!", "!")]
        [InlineData("a", "a")]
        [InlineData("aaaa", "aaaa")]
        [InlineData("a!", "a!")]
        [InlineData("Roma", "amoR")]
        [InlineData("Ro1994ma!", "am1994oR!")]
        [InlineData("  a1bcd    efg!h", "  d1cba    hgf!e")]
        [InlineData("He11o, Alex!af1", "oe11H, faxe!lA1")]
        public void Reverse_Words_NotAffectingSpecialCharacters(string input, string expected)
        {
            // arrange
            var anagram = new Anagram();

            // act 
            string actual = anagram.ReverseWord(input);

            // assert
            Assert.Equal(expected, actual);
        }
        /*[Fact]
        public void Reverse_ShouldReturnSpecialChar_IfWordIsSpecialChar()
        {
            // arrange
            var anagram = new Anagram();

            // act 
            string result = anagram.ReverseWord("!");

            // assert
            Assert.Equal("!", result);
        }
        [Fact]
        public void Reverse_ShouldReturnSimpleWord_IfWordIsSimple()
        {
            // arrange
            var anagram = new Anagram();

            // act 
            string result = anagram.ReverseWord("Roma");

            // assert
            Assert.Equal("amoR", result);
        }
        [Fact]
        public void Reverse_ShouldReturnMixedWord_IfWordIsMixed()
        {
            // arrange
            var anagram = new Anagram();

            // act 
            string result = anagram.ReverseWord("Ro1994ma!");

            // assert
            Assert.Equal("am1994oR!", result);
        }
        [Fact]

        public void Reverse_ShouldReturnTwoWords_IfEnteredTwoWords()
        {

            var anagram = new Anagram();

            string result = anagram.ReverseWord("  a1bcd    efg!h");

            Assert.Equal("  d1cba    hgf!e", result);
        }*/
    }
}
