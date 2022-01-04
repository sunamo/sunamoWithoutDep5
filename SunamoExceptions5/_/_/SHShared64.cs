using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SunamoExceptions
{
    public partial class SH
    {
        #region For easy copy from SH.cs
        public static string FirstLine(string item)
        {
            var lines = SH.GetLines(item);
            if (lines.Count == 0)
            {
                return string.Empty;
            }
            return lines[0];
        }

        /// <summary>
        /// Start at 0
        /// </summary>
        /// <param name="input"></param>
        /// <param name="lenght"></param>
        /// <returns></returns>
        public static string SubstringIfAvailable(string input, int lenght)
        {
            if (input.Length > lenght)
            {
                return input.Substring(0, lenght);
            }
            return input;
        }

        /// <summary>
        /// Remove with A2
        /// </summary>
        /// <param name="t"></param>
        /// <param name="ch"></param>
        public static string RemoveAfterFirst(string t, char ch)
        {
            int dex = t.IndexOf(ch);
            if (dex == -1 || dex == t.Length - 1)
            {
                return t;
            }

            return t.Substring(0, dex);
        }
        #endregion
    }
}