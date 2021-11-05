using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
namespace SunamoExceptions
{
    public partial class ThrowExceptions
    {
static Type type = typeof(ThrowExceptions);

        

        

        

        #region Only in xlf
        /// <summary>
        /// Return false in case of exception, otherwise true
        /// In console app is needed put in into try-catch error due to there is no globally handler of errors
        /// </summary>
        /// <param name="v"></param>
        private static bool ThrowIsNotNull(string stacktrace, object v)
        {
            if (v != null)
            {
                ThrowIsNotNull(stacktrace, v.ToString());
                return false;
            }
            return true;
        }

        static string dot = ".";
        public static void NotFoundTranslationKeyWithCustomError(string stacktrace, object type, string methodName, string message)
        {
            Custom(stacktrace, type, methodName, message);
        }

        public static void NotFoundTranslationKeyWithoutCustomError(string stacktrace, object type, string methodName, string message)
        {
            Custom(stacktrace, type, methodName, message);
        }
        #endregion
    }
}