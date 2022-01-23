using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SunamoExceptions
{
    public partial class CA
    {
        #region MyRegion
        #region For easy copy from CAShared64.cs
        /// <summary>
        /// Non direct edit
        /// </summary>
        /// <param name="backslash"></param>
        /// <param name="s"></param>
        public static List<string> TrimStart(char backslash, params string[] s)
        {
            return TrimStart(backslash, s.ToList());
        }

        /// <summary>
        /// Direct edit
        /// </summary>
        /// <param name="backslash"></param>
        /// <param name="s"></param>
        public static List<string> TrimStart(char backslash, List<string> s)
        {
            for (int i = 0; i < s.Count; i++)
            {
                s[i] = s[i].TrimStart(backslash);
            }
            return s;
        }
        #endregion
        #endregion
    }
}