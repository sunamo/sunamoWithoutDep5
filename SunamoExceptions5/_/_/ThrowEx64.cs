﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SunamoExceptions
{
    public partial class ThrowEx
    {
        #region For easy copy from ThrowEx64.cs
        public static void NotImplementedCase(object niCase)
        {
            ThrowIsNotNull(Exceptions.NotImplementedCase,niCase);
        }

        private static void ThrowIsNotNull(Func<string, object, string> f, object o)
        {
            ThrowExceptions.ThrowIsNotNullEx(f, o);
        }

        public static Tuple<string, string, string> t = null;

        public static void Custom(string v)
        {
            ThrowIsNotNull(Exceptions.Custom, v);
        }

        private static void ThrowIsNotNull(Func<string, string> f)
        {
            ThrowExceptions.ThrowIsNotNullEx(f);
        }

        private static void ThrowIsNotNull(Func<string, string, string> f, string a1)
        {
            ThrowExceptions.ThrowIsNotNullEx(f, a1);
        }

        private static string FullNameOfExecutedCode()
        {
            return ThrowExceptions.FullNameOfExecutedCode(t.Item1, t.Item2, true);
        }

        public static void NotImplementedMethod()
        {
            ThrowIsNotNull(Exceptions.NotImplementedMethod);
        }
        #endregion
    }
}