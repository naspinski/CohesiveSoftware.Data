using System.Text.RegularExpressions;

namespace CohesiveSoftware.Data.Helpers
{
    public class RegexHelper
    {
        public static string DigitsOnly(string s)
        {
            if (s == null) return string.Empty;
            var regexObj = new Regex(@"[^\d]");
            return regexObj.Replace(s, string.Empty);
        }
    }
}
