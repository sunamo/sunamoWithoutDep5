using SunamoExceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SunamoExceptions
{
    public static partial class IEnumerableExtensions
    {
        #region For easy copy from IEnumerableExtensionsShared64.cs
        public static int Count(this IEnumerable e)
        {
            return CA.Count(e);
        }
        #endregion
    }
}