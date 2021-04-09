using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Palindrones.Tests
{
    public class word_is_a_palindrone
    {
        [Theory]
        [InlineData("No x in Nixon", true)]
        [InlineData("Some men interpret nine memos", true)]
        [InlineData("Stats", true)]
        [InlineData("Stars", false)]
    public void test_is_a_palindrone(string word, bool expected)
    {
        var checker = new CheckForPalindrone();
        var actualResult = checker.myPalidroneChecker(word);
        Assert.Equal(actualResult, expected);
    }
    }
}
