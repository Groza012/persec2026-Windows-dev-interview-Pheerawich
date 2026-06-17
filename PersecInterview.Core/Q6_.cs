using System.Collections.Generic;
using System.Linq;

namespace PersecInterview.Core
{
    public class Q6_Tribonacci
    {
        public int[] GetTribonacci(int[] signature, int n)
        {
            if (n == 0) return new int[0];
            var result = signature.ToList();

            while (result.Count < n)
            {
                int nextVal = 0;
                int count = result.Count;
                if (count >= 1) nextVal += result[count - 1];
                if (count >= 2) nextVal += result[count - 2];
                if (count >= 3) nextVal += result[count - 3];
                result.Add(nextVal);
            }
            return result.Take(n).ToArray();
        }
    }
}