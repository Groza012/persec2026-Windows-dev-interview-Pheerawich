using System.Linq;
using System.Text.RegularExpressions;

namespace PersecInterview.Core
{
    public class Q2_SortArray
    {
        public string[] SortArray(string[] arr)
        {
            return arr
                .Select(s => new
                {
                    Original = s,
                    Match = Regex.Match(s, @"^(\D*)(\d+)")
                })
                .OrderBy(x => x.Match.Success ? x.Match.Groups[1].Value : x.Original)
                .ThenBy(x => x.Match.Success ? int.Parse(x.Match.Groups[2].Value) : 0)
                .Select(x => x.Original)
                .ToArray();
        }
    }
}