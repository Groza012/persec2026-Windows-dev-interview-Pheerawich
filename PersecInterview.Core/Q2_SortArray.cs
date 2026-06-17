using System.Linq;
using System.Text.RegularExpressions;

namespace PersecInterview.Core
{
    public class Q2_SortArray
    {
        public string[] SortArray(string[] arr)
        {
            return arr.OrderBy(s => Regex.Replace(s, @"\d+", ""))
                      .ThenBy(s => {
                          var match = Regex.Match(s, @"\d+");
                          return match.Success ? int.Parse(match.Value) : 0;
                      }).ToArray();
        }
    }
}