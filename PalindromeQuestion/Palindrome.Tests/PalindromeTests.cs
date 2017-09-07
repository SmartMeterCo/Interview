using System;
using Xunit;

namespace Palindrome.Tests
{
    public class PalindromeTests
    {
        [Fact]
        public void IsPalindromeTest()
        {
            Palindrome.IsPalindrome("hello", "olleh");
        }
    }
}
