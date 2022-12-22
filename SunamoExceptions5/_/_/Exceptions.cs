using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoExceptions
{
    public partial class Exceptions
    {
        #region For easy copy from Exceptions.cs - all ok 16-10-21
        public static string DifferentCountInLists(string before, string namefc, int countfc, string namesc, int countsc)
        {
            if (countfc != countsc)
            {
                // sess and SunamoPageHelperSunamo have the i18n method. Sess calculates that the text translation is in dictionaries, while SunamoPageHelperSunamo needs to have a method set for this. If this doesn't work, replace it with SunamoPageHelperSunamo
                // coz SunamoPageHelperSunamo is not in SunamoExceptions available
                return CheckBefore(before) + " " + sess.i18n(XlfKeys.DifferentCountElementsInCollection) + " " + string.Concat(namefc + AllStrings.swda + countfc) + " vs. " + string.Concat(namesc + AllStrings.swda + countsc);
            }

            return null;
        }
        #endregion
    }
}
