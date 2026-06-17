using Xunit;
using PersecInterview.Core;

namespace PersecInterview.Tests
{
    public class AllTests
    {
        [Fact]
        public void Q1_Test()
        {
            var q = new Q1_ValidParentheses();
            Assert.True(q.IsValid("()"));
            Assert.False(q.IsValid("([{)"));
            Assert.True(q.IsValid("([{}])"));
        }

        [Fact]
        public void Q2_Test()
        {
            var q = new Q2_SortArray();
            Assert.Equal(new[] { "SG20", "TH2", "TH19" }, q.SortArray(new[] { "TH19", "SG20", "TH2" }));
            Assert.Equal(new[] { "TH1", "TH3Netflix", "TH7", "TH10" }, q.SortArray(new[] { "TH10", "TH3Netflix", "TH1", "TH7" }));
        }

        [Fact]
        public void Q3_Test()
        {
            var q = new Q3_Autocomplete();
            var result = q.Autocomplete("th", new[] { "Mother", "Think", "Worthy", "Apple", "Android" }, 2);
            Assert.Equal(new[] { "Think", "Mother" }, result);
        }

        [Fact]
        public void Q4_Test()
        {
            var q = new Q4_RomanNumerals();
            Assert.Equal("MCMLXXXIX", q.IntToRoman(1989));
            Assert.Equal(68, q.RomanToInt("LXVIII"));
        }

        [Fact]
        public void Q5_Test()
        {
            var q = new Q5_SortPositiveInt();
            Assert.Equal(8300, q.SortDescending(3008));
            Assert.Equal(9981, q.SortDescending(1989));
        }

        [Fact]
        public void Q6_Test()
        {
            var q = new Q6_Tribonacci();
            Assert.Equal(new[] { 1, 3, 5, 9, 17 }, q.GetTribonacci(new[] { 1, 3, 5 }, 5));
            Assert.Equal(new[] { 2, 2, 2 }, q.GetTribonacci(new[] { 2, 2, 2 }, 3));
        }
    }
}