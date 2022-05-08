using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
namespace SunamoExceptions
{
    public partial class ThrowEx
    {
static Type type = typeof(ThrowEx);

        

        

        

        #region Only in xlf
        /// <summary>
        /// Return false in case of exception, otherwise true
        /// In console app is needed put in into try-catch error due to there is no globally handler of errors
        /// </summary>
        /// <param name="v"></param>
        private static bool ThrowIsNotNull( object v)
        {
            if (v != null)
            {
                ThrowIsNotNull(v.ToString());
                return false;
            }
            return true;
        }

        static string dot = ".";
        public static void NotFoundTranslationKeyWithCustomError( string message)
        {
            Custom(ThrowIsNotNull( message);
        }

        public static void NotFoundTranslationKeyWithoutCustomError( string message)
        {
            Custom(ThrowIsNotNull( message);
        }
        #endregion
    }
}