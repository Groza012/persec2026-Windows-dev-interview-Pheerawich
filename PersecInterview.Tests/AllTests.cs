using Xunit;
using PersecInterview.Core;

namespace PersecInterview.Tests
{
    public class InterviewTests
    {
        [Fact]
        public void Q1_Test_ValidParentheses()
        {
            var q = new Q1_ValidParentheses();
            Assert.True(q.IsValid("()"));
            Assert.False(q.IsValid("([{)"));
            Assert.True(q.IsValid("([{}])"));
            Assert.False(q.IsValid("([[{}]]]")); 
            Assert.False(q.IsValid(")"));
            Assert.False(q.IsValid("(]}])"));
            Assert.False(q.IsValid("([)]"));
            Assert.False(q.IsValid("{"));
        }

        [Fact]
        public void Q2_Test_SortArray()
        {
            var q = new Q2_SortArray();
            Assert.Equal(new[] { "SG20", "TH2", "TH19" }, q.SortArray(new[] { "TH19", "SG20", "TH2" }));
            Assert.Equal(new[] { "TH1", "TH3Netflix", "TH7", "TH10" }, q.SortArray(new[] { "TH10", "TH3Netflix", "TH1", "TH7" }));
        }

        [Fact]
        public void Q3_Test_Autocomplete()
        {
            var q = new Q3_Autocomplete();
            var result = q.Autocomplete("th", new[] { "Mother", "Think", "Worthy", "Apple", "Android" }, 2);
            Assert.Equal(new[] { "Think", "Mother" }, result);

            
            var result2 = q.Autocomplete("th", new[] { "Worthy", "Mother" }, 2);
            Assert.Equal(new[] { "Worthy", "Mother" }, result2);
        }

        [Fact]
        public void Q4_Test_RomanNumerals()
        {
            var q = new Q4_RomanNumerals();
            // Test Int To Roman
            Assert.Equal("MCMLXXXIX", q.IntToRoman(1989));
            Assert.Equal("MM", q.IntToRoman(2000));
            Assert.Equal("LXVIII", q.IntToRoman(68));
            Assert.Equal("CIX", q.IntToRoman(109));

            // Test Roman To Int
            Assert.Equal(1989, q.RomanToInt("MCMLXXXIX"));
            Assert.Equal(2000, q.RomanToInt("MM"));
            Assert.Equal(68, q.RomanToInt("LXVIII"));
            Assert.Equal(109, q.RomanToInt("CIX"));
        }

        [Fact]
        public void Q5_Test_SortPositiveInt()
        {
            var q = new Q5_SortPositiveInt();
            Assert.Equal(8300, q.SortDescending(3008));
            Assert.Equal(9981, q.SortDescending(1989));
            Assert.Equal(9762, q.SortDescending(2679));
            Assert.Equal(9631, q.SortDescending(9163));
        }

        [Fact]
        public void Q6_Test_Tribonacci()
        {
            var q = new Q6_Tribonacci();
          
            Assert.Equal(new[] { 1, 3, 5, 9, 17 }, q.GetTribonacci(new[] { 1, 3, 5 }, 5));
            Assert.Equal(new[] { 2, 2, 2 }, q.GetTribonacci(new[] { 2, 2, 2 }, 3));
            Assert.Equal(new[] { 10, 10, 10, 30 }, q.GetTribonacci(new[] { 10, 10, 10 }, 4));

            Assert.Empty(q.GetTribonacci(new[] { 5, 2, 0 }, 0));
            Assert.Equal(new[] { 1 }, q.GetTribonacci(new[] { 1 }, 1));
            Assert.Equal(new[] { 3, 4, 1, 8 }, q.GetTribonacci(new[] { 3, 4, 1 }, 4));
            Assert.Equal(new[] { 0, 0, 0 }, q.GetTribonacci(new int[0], 3)); // signature ว่าง
        }
    }
}