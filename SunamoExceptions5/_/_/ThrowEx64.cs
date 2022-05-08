using System;
using System.Collections.Generic;
using System.Text;

namespace SunamoExceptions
{
    public partial class ThrowEx
    {
        #region For easy copy from ThrowEx64.cs
        public static void NotImplementedCase(object niCase)
        {
            ThrowIsNotNull(Exceptions.NotImplementedCase, niCase);
        }

        private static void ThrowIsNotNull(Func<string, object, string> f, object o)
        {
            ThrowEx.ThrowIsNotNullEx(f, o);
        }

        private static void ThrowIsNotNull(Func<string, Exception, string> f, Exception o)
        {
            ThrowEx.ThrowIsNotNullEx(f, o);
        }

        public static Tuple<string, string, string> t = null;

        public static void Custom(string v, string v2 = Consts.se)
        {
            ThrowIsNotNull(Exceptions.Custom, SH.Join(CA.ToList<string>(v, v2), Consts.se));
        }

        private static void ThrowIsNotNull(Func<string, string> f)
        {
            ThrowEx.ThrowIsNotNullEx(f);
        }

        private static void ThrowIsNotNull(Func<string, string, string> f, string a1)
        {
            ThrowEx.ThrowIsNotNullEx(f, a1);
        }

        private static string FullNameOfExecutedCode()
        {
            return ThrowEx.FullNameOfExecutedCode(t.Item1, t.Item2, true);
        }

        public static void NotImplementedMethod()
        {
            ThrowIsNotNull(Exceptions.NotImplementedMethod);
        }
        #endregion
    }
}