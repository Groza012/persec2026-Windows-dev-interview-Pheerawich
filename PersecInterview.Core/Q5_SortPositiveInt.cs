using System;
using System.Linq;

namespace PersecInterview.Core
{
    public class Q5_SortPositiveInt
    {
        public int SortDescending(int num)
        {
            string sortedStr = new string(num.ToString().OrderByDescending(c => c).ToArray());
            return int.Parse(sortedStr);
        }
    }
}