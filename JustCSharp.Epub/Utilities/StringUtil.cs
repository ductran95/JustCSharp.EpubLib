using System;
using System.Linq;
using System.Text;

namespace JustCSharp.Epub.Utilities
{
    /// <summary>
    /// Various string utility functions.
    /// </summary>
    /// <remarks>
    /// Most of the functions herein are re-implementations of the ones in apache
    /// commons stringUtils. The reason for re-implementing this is that the
    /// functions are fairly simple and using my own implementation saves the
    /// inclusion of a 200Kb jar file.
    /// </remarks>
    public static class StringUtil
    {
        /// <summary>
        /// Changes a path containing '..', '.' and empty dirs into a path that
        /// doesn't. X/foo/../Y is changed into 'X/Y', etc. Does not handle invalid
        /// paths like "../".
        /// </summary>
        /// <param name="path"></param>
        /// <returns>the normalized path</returns>
        public static string CollapsePathDots(string path)
        {
            var stringParts = path.Split("/", StringSplitOptions.RemoveEmptyEntries).ToList();
            int i = 0;
            while (i < stringParts.Count - 1)
            {
                string currentDir = stringParts[i];
                if (currentDir.Equals("."))
                {
                    stringParts.RemoveAt(i);
                    i--;
                }
                else if (currentDir.Equals(".."))
                {
                    stringParts.RemoveAt(i - 1);
                    stringParts.RemoveAt(i - 1);
                    i -= 2;
                }

                i++;
            }

            StringBuilder result = new StringBuilder();
            if (path.StartsWith("/"))
            {
                result.Append('/');
            }

            for (i = 0; i < stringParts.Count; i++)
            {
                result.Append(stringParts[i]);
                if (i < (stringParts.Count - 1))
                {
                    result.Append('/');
                }
            }

            return result.ToString();
        }

        /// <summary>
        /// Pretty toString printer.
        /// </summary>
        /// <param name="keyValues"></param>
        /// <returns>a string representation of the input values</returns>
        public static string ToString(params object[] keyValues)
        {
            StringBuilder result = new StringBuilder();
            result.Append('[');
            for (int i = 0; i < keyValues.Length; i += 2)
            {
                if (i > 0)
                {
                    result.Append(", ");
                }

                result.Append(keyValues[i]);
                result.Append(": ");
                Object value = null;
                if ((i + 1) < keyValues.Length)
                {
                    value = keyValues[i + 1];
                }

                if (value == null)
                {
                    result.Append("<null>");
                }
                else
                {
                    result.Append('\'');
                    result.Append(value);
                    result.Append('\'');
                }
            }

            result.Append(']');
            return result.ToString();
        }

        public static int GetHashCode(params string[] values)
        {
            int result = 31;
            for (int i = 0; i < values.Length; i++)
            {
                result ^= values[i].GetHashCode();
            }

            return result;
        }
        
        /// <summary>
        /// Whether the given source string ends with the given suffix, ignoring
        /// case
        /// </summary>
        /// <param name="source"></param>
        /// <param name="suffix"></param>
        /// <returns></returns>
        public static bool EndsWithIgnoreCase(String source, String suffix) {
            if (string.IsNullOrEmpty(suffix)) {
                return true;
            }
            if (string.IsNullOrEmpty(source)) {
                return false;
            }
            if (suffix.Length > source.Length) {
                return false;
            }
            return source.ToLower().EndsWith(suffix.ToLower());
        }

        /// <summary>
        /// Gives the substring of the given text before the given separator.
        /// </summary>
        /// <remarks>
        /// If the text does not contain the given separator then the given text is
        /// returned.
        /// </remarks>
        /// <param name="text"></param>
        /// <param name="separator"></param>
        /// <returns>the substring of the given text before the given separator.</returns>
        public static string SubstringBefore(string text, char separator)
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }

            int sepPos = text.IndexOf(separator);
            if (sepPos < 0)
            {
                return text;
            }

            return text.Substring(0, sepPos);
        }

        /// <summary>
        /// Gives the substring of the given text before the last occurrence of the
        /// given separator.
        /// </summary>
        /// <remarks>
        /// If the text does not contain the given separator then the given text is
        /// returned.
        /// </remarks>
        /// <param name="text"></param>
        /// <param name="separator"></param>
        /// <returns>the substring of the given text before the last occurrence of the given separator.</returns>
        public static string SubstringBeforeLast(string text, char separator)
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }

            int cPos = text.LastIndexOf(separator);
            if (cPos < 0)
            {
                return text;
            }

            return text.Substring(0, cPos);
        }

        /// <summary>
        /// Gives the substring of the given text after the last occurrence of the
        /// given separator.
        /// </summary>
        /// <remarks>
        /// If the text does not contain the given separator then "" is returned.
        /// </remarks>
        /// <param name="text"></param>
        /// <param name="separator"></param>
        /// <returns>the substring of the given text after the last occurrence of the given separator.</returns>
        public static string SubstringAfterLast(string text, char separator)
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }

            int cPos = text.LastIndexOf(separator);
            if (cPos < 0)
            {
                return "";
            }

            return text.Substring(cPos + 1);
        }

        /// <summary>
        /// Gives the substring of the given text after the given separator.
        /// </summary>
        /// <remarks>
        /// If the text does not contain the given separator then "" is returned.
        /// </remarks>
        /// <param name="text"></param>
        /// <param name="c"></param>
        /// <returns>the substring of the given text after the given separator.</returns>
        public static string SubstringAfter(string text, char c)
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }

            int cPos = text.IndexOf(c);
            if (cPos < 0)
            {
                return "";
            }

            return text.Substring(cPos + 1);
        }
    }
}