using SunamoException;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoExceptions
{
    public partial class Exceptions
    {
        #region For easy copy from ExceptionsShared.cs

        /// <summary>
        /// Verify whether A2 contains A3
        /// </summary>
        /// <param name="before"></param>
        /// <param name="originalText"></param>
        /// <param name="shouldContains"></param>
        public static string NotContains(string before, string originalText, params string[] shouldContains)
        {
            List<string> notContained = new List<string>();
            foreach (var item in shouldContains)
            {
                if (!originalText.Contains(item))
                {
                    notContained.Add(item);
                }
            }

            if (notContained.Count == 0)
            {
                return null;
            }
            return CheckBefore(before) + originalText + " dont contains: " + SH.Join(notContained, AllStrings.comma);
        }

        public static string FolderCannotBeDeleted(string v, string repairedBlogPostsFolder, Exception ex)
        {
            return v + repairedBlogPostsFolder + TextOfExceptions(ex);
        }

        public static string HasNotKeyDictionary<Key, Value>(string v, string nameDict, IDictionary<Key, Value> qsDict, Key remains)
        {
            if (!qsDict.ContainsKey(remains))
            {
                return CheckBefore(v) + nameDict + " does not contains key " + remains;
            }
            return null;
        }

        public static string CannotCreateDateTime(string v, int year, int month, int day, int hour, int minute, int seconds, Exception ex)
        {
            return v + $"Cannot create DateTime with: year: {year} month: {month} day: {day} hour: {hour} minute: {minute} seconds: {seconds} " + TextOfExceptions(ex);
        }



        public static string IsEmpty(string before, IEnumerable folders, string colName, string additionalMessage)
        {
            if (folders.Count() == 0)
            {
                return before + colName + " has no elements. " + additionalMessage;
            }
            return null;
        }



        public const string sp = AllStrings.space;


        public static string CannotMoveFolder(string before, string item, string nova, Exception ex)
        {
            return before + $"Cannot move folder from {item} to {nova}" + sp + TextOfExceptions(ex);
        }

        public static string ExcAsArg(string before, Exception ex, string message)
        {
            return before + message + AllStrings.space + Exceptions.TextOfExceptions(ex);
        }

        public static string Ftp(string before,Exception ex, string message)
        {
            return before + message + AllStrings.space + Exceptions.TextOfExceptions(ex);
        }

        public static string IO(string before,string message)
        {
            return before + message;
        }

        public static string InvalidOperation(string before,string message)
        {
            return before + message;
        }

        public static string ArgumentOutOfRange(string before,string message)
        {
            return before + message;
        }

        public static string Format(string before,string message)
        {
            return before + message;
        }

        public static string FtpSecurityNotAvailable(string before,string message)
        {
            return before + message;
        }

        public static string FtpCommand(string before,object s)
        {
            return before + DumpAsString(s);
        }

        public static string FtpAuthentication(string before,object s)
        {
            return before + DumpAsString(s);
        }

        public static string DumpAsString(object s)
        {
            return RH.DumpAsString(string.Empty, s);
        }

        public static string InvalidCast(string before,string message)
        {
            return before + message;
        }

        public static string ObjectDisposed(string before,string message)
        {
            return before + message;
        }
        
        public static string Timeout(string before,string message)
        {
            return before + message;
        }

        public static string FtpMissingSocket(string before, Exception ex)
        {
            return before + Exceptions.TextOfExceptions(ex);
        }

        public static string UriFormat(string before, string ex)
        {
            return before +ex;
        }
        #endregion
    }
}