using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SunamoExceptions
{
    public partial class ThrowEx
    {

        

        #region For easy copy from ThrowExShared.cs - all ok 17-10-21


        public static void DummyNotThrow(Exception ex)
        {

        }

        public static void NotImplementedMethod()
        {
            ThrowIsNotNull(Exceptions.NotImplementedMethod(FullNameOfExecutedCode(t.Item1, t.Item2)));
        }

        /// <summary>
        /// Verify whether A3 contains A4
        /// true if everything is OK
        /// false if some error occured
        /// </summary>
        /// <param name="type"></param>
        /// <param name="v"></param>
        /// <param name="p"></param>
        /// <param name="after"></param>
        public static bool NotContains(string stacktrace, object type, string v, string p, params string[] after)
        {
            return ThrowIsNotNull(Exceptions.NotContains(FullNameOfExecutedCode(type, v, true), p, after));
        }

        /// <summary>
        /// Default use here method with one argument
        /// Return false in case of exception, otherwise true
        /// In console app is needed put in into try-catch error due to there is no globally handler of errors
        /// </summary>
        /// <param name="type"></param>
        /// <param name="methodName"></param>
        /// <param name="exception"></param>
        public static bool ThrowIsNotNull( string exception)
        {
            if (exception != null)
            {
                ThrowEx.Custom(exception);
                return false;
            }
            return true;
        }
        #endregion
    }
}