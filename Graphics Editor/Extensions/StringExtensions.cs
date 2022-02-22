using System;
using System.Text.RegularExpressions;

namespace Graphics_Editor
{
    public static class StringExtensions
    {
        public static bool IsValidWindowsFilename(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;
            Regex containsWrongSymvols = new Regex("[" + Regex.Escape(new string(System.IO.Path.GetInvalidFileNameChars())) + "]");
            if (containsWrongSymvols.IsMatch(str))
                return false;
            return true;
        }
    }
}
