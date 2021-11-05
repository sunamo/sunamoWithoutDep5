﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoExceptions
{
    public partial class ThrowExceptions
    {
        #region For easy copy from ThrowExceptionsShared.cs - all ok 17-10-21

        
        public static void DummyNotThrow(Exception ex)
        {

        }

        public static void NotImplementedMethod(string stacktrace, object type, string methodName)
        {
            ThrowIsNotNull(stacktrace, Exceptions.NotImplementedMethod(FullNameOfExecutedCode(type, methodName)));
        }

        /// <summary>
        /// A1 have to be Dictionary<T,U>, not IDictionary without generic
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="type"></param>
        /// <param name="v"></param>
        /// <param name="en"></param>
        /// <param name="dictName"></param>
        /// <param name="key"></param>
        public static void KeyNotFound<T, U>(string stacktrace, object type, string v, IDictionary<T, U> en, string dictName, T key)
        {
            ThrowIsNotNull(stacktrace, Exceptions.KeyNotFound(FullNameOfExecutedCode(type, v), en, dictName, key));
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
            return ThrowIsNotNull(stacktrace, Exceptions.NotContains(FullNameOfExecutedCode(type, v, true), p, after));
        }

        /// <summary>
        /// Default use here method with one argument
        /// Return false in case of exception, otherwise true
        /// In console app is needed put in into try-catch error due to there is no globally handler of errors
        /// </summary>
        /// <param name="type"></param>
        /// <param name="methodName"></param>
        /// <param name="exception"></param>
        public static bool ThrowIsNotNull(string stacktrace, object type, string methodName, string exception)
        {
            if (exception != null)
            {
                ThrowExceptions.Custom(Exc.GetStackTrace(), type, Exc.CallingMethod(), exception);
                return false;
            }
            return true;
        }
        #endregion
    }
}