using SunamoExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoExceptions
{
    public partial class Exceptions
    {
        #region From easy copy from ExceptionsShared64.cs - all ok 16-10-21
        /// <summary>
        /// Start with Consts.Exception to identify occur
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="alsoInner"></param>
        public static string TextOfExceptions(Exception ex, bool alsoInner = true)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Consts.Exception);
            sb.AppendLine(ex.Message);
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
                sb.AppendLine(ex.Message);
            }
            var r = sb.ToString();
            return r;
        }

        public static string ArgumentOutOfRangeException(string before, string paramName, string message)
        {
            if (paramName == null)
            {
                paramName = string.Empty;
            }

            if (message == null)
            {
                message = string.Empty;
            }

            return CheckBefore(before) + paramName + " " + message;
        }

        public static string IsNull(string before, string variableName, object variable)
        {
            if (variable == null)
            {
                return CheckBefore(before) + variable + " " + "is null" + ".";
            }

            return null;
        }

        public static string NotImplementedCase(string before, object niCase)
        {
            string fr = string.Empty;
            if (niCase != null)
            {
                fr = " for ";
                if (niCase.GetType() == typeof(Type))
                {
                    fr += ((Type)niCase).FullName;
                }
                else
                {
                    fr += niCase.ToString();
                }
            }

            return CheckBefore(before) + "Not implemented case" + fr + " . public program error. Please contact developer" + ".";
        }

        public static object Custom(string before, string message)
        {
            return CheckBefore(before) + message;
        }

        private static string CheckBefore(string before)
        {
            if (string.IsNullOrWhiteSpace(before))
            {
                return "";
            }
            return before + ": ";
        }
        #endregion
    }
}