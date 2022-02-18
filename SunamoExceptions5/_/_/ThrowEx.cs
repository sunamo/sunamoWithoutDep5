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
        #endregion
    }
}