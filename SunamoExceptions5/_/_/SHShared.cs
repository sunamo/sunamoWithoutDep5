using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoExceptions
{
    public partial class SH
    {
        public static Type type = typeof(SH);

        #region For easy copy

        /// <summary>
        /// Stejná jako metoda ReplaceAll, ale bere si do A3 pouze jediný parametr, nikoliv jejich pole
        /// </summary>
        /// <param name="vstup"></param>
        /// <param name="zaCo"></param>
        /// <param name="co"></param>
        public static string ReplaceAll2(string vstup, string zaCo, string co)
        {
            return vstup.Replace(co, zaCo);
        }

        public static string GetTextBetweenTwoChars(string p, int begin, int end)
        {
            if (end > begin)
            {
                // a(1) - 1,3
                return p.Substring(begin + 1, end - begin - 1);
                // originally
                //return p.Substring(begin+1, end - begin - 1);
            }
            return p;
        }


        /// <summary>
        /// Work like everybody excepts, from a {b} c return b
        /// </summary>
        /// <param name="p"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        public static string GetTextBetweenTwoChars(string p, char beginS, char endS, bool throwExceptionIfNotContains = true)
        {
            var begin = p.IndexOf(beginS);
            var end = p.IndexOf(endS, begin + 1);
            if (begin == NumConsts.mOne || end == NumConsts.mOne)
            {
                if (throwExceptionIfNotContains)
                {
                    ThrowExceptions.NotContains(null, type, "GetTextBetween", p, beginS.ToString(), endS.ToString());
                }
            }
            else
            {
                return GetTextBetweenTwoChars(p, begin, end);
            }
            return p;
        }
        #endregion
    }
}