using System.Linq;

namespace PersecInterview.Core
{
    public class Q3_Autocomplete
    {
        public string[] Autocomplete(string search, string[] items, int maxResult)
        {
            string lowerSearch = search.ToLower();
            return items
                .Where(i => i.ToLower().Contains(lowerSearch))
                .OrderBy(i =>
                {
                    var lowerI = i.ToLower();
                    if (lowerI.StartsWith(lowerSearch)) return 1;
                    if (lowerI.EndsWith(lowerSearch)) return 3;
                    return 2;
                })
                .Take(maxResult)
                .ToArray();
        }
    }
}