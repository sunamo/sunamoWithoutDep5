using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SunamoExceptions
{
    public partial class ThrowExceptions
    {
        #region For easy copy from ThrowExceptions.cs
        #region DifferentCountInLists

        public static void ExcAsArg(Exception ex, string p = Consts.se)
        {
            var mth = new StackTrace().GetFrame(1).GetMethod();
            var cls = mth.ReflectedType.Name;
            ThrowIsNotNull(Exc.GetStackTrace(), Exceptions.ExcAsArg(FullNameOfExecutedCode(cls, mth.Name), ex, p));
        }
        #endregion
        #endregion
    }
}