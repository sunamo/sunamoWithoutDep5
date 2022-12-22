using SunamoException;
using System;

namespace SunamoExceptions
{
    public partial class ThrowEx
    {
        #region For easy copy from ThrowEx.cs
        public static Func<char, bool> IsLockedByBitLocker;

        public static bool LockedByBitLocker(string path)
        {
            // pokračovat na tohle 
            if (IsLockedByBitLocker != null)
            {
                var p = path[0];

                if (IsLockedByBitLocker(p))
                {
                    Custom($"Drive {p}:\\ is locked by BitLocker");
                    return true;
                }
            }
            return false;
        }

        public static void CallingSyncMethodInAsyncApp()
        {
            Custom("Calling sync method in async app");
        }

        public static void Argument(string a1, string a2 = null)
        {
            Custom(a1, a2);
        }

        public static void ArgumentNull(string a1, string a2 = null)
        {
            Custom(a1, a2);
        }

        public static void ExcAsArg(Exception ex, string message = Consts.se)
        {
            ThrowEx.ThrowIsNotNullEx(Exceptions.ExcAsArg, ex, message);
        }

        public static void Ftp(string message, Exception ex = null)
        {
            ThrowEx.ThrowIsNotNullEx(Exceptions.Ftp, ex, message);
        }

        public static void IO(string v)
        {
            ThrowIsNotNull(Exceptions.IO, v);
        }

        public static void InvalidOperation(string s)
        {
            ThrowIsNotNull(Exceptions.InvalidOperation, s);
        }

        public static void ArgumentOutOfRange(string s)
        {
            ThrowIsNotNull(Exceptions.ArgumentOutOfRange, s);
        }

        public static void FtpCommand(object s)
        {
            ThrowIsNotNull(Exceptions.FtpCommand, s);
        }

        public static void FtpAuthentication(object s)
        {
            ThrowIsNotNull(Exceptions.FtpAuthentication, s);
        }

        //FtpAuthentication

        public static void InvalidCast(string v)
        {
            ThrowIsNotNull(Exceptions.InvalidCast, v);
        }

        public static void ObjectDisposed(string v)
        {
            ThrowIsNotNull(Exceptions.ObjectDisposed, v);
        }

        public static void Timeout(string v)
        {
            ThrowIsNotNull(Exceptions.Timeout, v);
        }

        public static void FtpSecurityNotAvailable(string v)
        {
            ThrowIsNotNull(Exceptions.FtpSecurityNotAvailable, v);
        }

        //FtpSecurityNotAvailable

        public static void FtpMissingSocket(Exception ex)
        {
            ThrowIsNotNull(Exceptions.FtpMissingSocket, ex);
        }
        
        public static void UriFormat(string v)
        {
            ThrowIsNotNull(Exceptions.UriFormat, v);
        }

        public static void FtpListParse()
        {
            Custom("FtpListParse");
        }

        public static void Format(string v)
        {
            ThrowIsNotNull(Exceptions.Format, v);
        }
        #endregion
    }
}
