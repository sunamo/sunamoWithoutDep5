﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
namespace SunamoExceptions
{
    public class ThrowExceptions
    {
static Type type = typeof(ThrowExceptions);

        #region For easy copy from ThrowExceptions.cs
        #region DifferentCountInLists
        public static void DifferentCountInLists(string stacktrace, object type, string methodName, string namefc, int countfc, string namesc, int countsc)
        {
            ThrowIsNotNull(stacktrace, Exceptions.DifferentCountInLists(FullNameOfExecutedCode(type, methodName, true), namefc, countfc, namesc, countsc));
        }

        public static void DifferentCountInLists(string stacktrace, object type, string methodName, string namefc, IEnumerable replaceFrom, string namesc, IEnumerable replaceTo)
        {
            DifferentCountInLists(stacktrace, type, methodName, namefc, replaceFrom.Count(), namesc, replaceTo.Count());
        }
        #endregion
        #endregion

        #region For easy copy in SunamoException project from ThrowExceptionsShared64.cs
        /// <summary>
        /// true if everything is OK
        /// false if some error occured
        /// In console app is needed put in into try-catch error due to there is no globally handler of errors
        /// </summary>
        /// <param name="exception"></param>
        public static bool ThrowIsNotNull(string stacktrace, string exception)
        {
            if (exception != null)
            {
                if (Exc.aspnet)
                {
                    //if (HttpRuntime.AppDomainAppId != null)
                    //{
                    //Debugger.Break();
                    // Will be written in globalasax error
                    writeServerError(stacktrace, exception);
                    throw new Exception(exception);
                    //}
                }
                else
                {
                    throw new Exception(exception);
                }

                return false;
            }
            return true;
        }

        public static void IsNotWindowsPathFormat(string stacktrace, object type, string methodName, string argName, string argValue)
        {
            ThrowIsNotNull(stacktrace, Exceptions.IsNotWindowsPathFormat(FullNameOfExecutedCode(type, methodName, true), argName, argValue));
        }

        public static void IsNullOrEmpty(string stacktrace, object type, string methodName, string argName, string argValue)
        {
            ThrowIsNotNull(stacktrace, Exceptions.IsNullOrEmpty(FullNameOfExecutedCode(type, methodName, true), argName, argValue));
        }

        public static void ArgumentOutOfRangeException(string stacktrace, object type, string methodName, string paramName, string message = null)
        {
            ThrowIsNotNull(stacktrace, Exceptions.ArgumentOutOfRangeException(FullNameOfExecutedCode(type, methodName, true), paramName, message));
        }

        public static void IsNull(string stacktrace, object type, string methodName, string variableName, object variable = null)
        {
            ThrowIsNotNull(stacktrace, Exceptions.IsNull(FullNameOfExecutedCode(type, methodName, true), variableName, variable));
        }

        public static Action<string, string> writeServerError;

        public static void NotImplementedCase(string stacktrace, object type, string methodName, object niCase)
        {
            ThrowIsNotNull(stacktrace, Exceptions.NotImplementedCase(FullNameOfExecutedCode(type, methodName, true), niCase));
        }

        


        /// <summary>
        /// First can be Method base, then A2 can be anything
        /// </summary>
        /// <param name="type"></param>
        /// <param name="methodName"></param>
        public static string FullNameOfExecutedCode(object type, string methodName, bool fromThrowExceptions = false)
        {
            if (methodName == null)
            {
                int depth = 2;
                if (fromThrowExceptions)
                {
                    depth++;
                }
                methodName = Exc.CallingMethod(depth);
            }
            string typeFullName = string.Empty;
            if (type is Type)
            {
                var type2 = ((Type)type);
                typeFullName = type2.FullName;
            }
            else if (type is MethodBase)
            {
                MethodBase method = (MethodBase)type;
                typeFullName = method.ReflectedType.FullName;
                methodName = method.Name;
            }
            else if (type is string)
            {
                typeFullName = type.ToString();
            }
            else
            {
                Type t = type.GetType();
                typeFullName = t.FullName;
            }
            return string.Concat(typeFullName, dot, methodName);
        }
        #endregion


        #region For easy copy in SunamoException project from ThrowExceptionsShared.cs
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

        

        

        

        



        

        

        public static void Custom(string stacktrace, object type, string methodName, string message)
        {
            ThrowIsNotNull(stacktrace, Exceptions.Custom(FullNameOfExecutedCode(type, methodName, true), message));
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