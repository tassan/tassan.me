using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Tassan.Me.API.Base.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveAccents(this string text)
        {
            return new string(text
                .Normalize(NormalizationForm.FormD)
                .Where(ch => char.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
                .ToArray());
        }
        
        public static string RemoveSpecialCharacters(this string str)
        {
            return Regex.Replace(str, @"[^\w\d\s]", "");
        }
    }
}