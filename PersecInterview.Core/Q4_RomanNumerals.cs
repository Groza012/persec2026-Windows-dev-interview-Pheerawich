using System.Collections.Generic;

namespace PersecInterview.Core
{
    public class Q4_RomanNumerals
    {
        public string IntToRoman(int num)
        {
            string[] roman = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string result = "";
            for (int i = 0; i < 13; i++)
            {
                while (num >= values[i])
                {
                    num -= values[i];
                    result += roman[i];
                }
            }
            return result;
        }

        public int RomanToInt(string s)
        {
            var map = new Dictionary<char, int> { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && map[s[i]] < map[s[i + 1]])
                    sum -= map[s[i]];
                else
                    sum += map[s[i]];
            }
            return sum;
        }
    }
}