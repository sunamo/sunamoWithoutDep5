using System;
using System.Collections.Generic;
using System.Text;

namespace SunamoExceptions
{
    public class sess
    {
        static Type type = typeof(sess);

        public static string i18n(string k)
        {
            switch (k)
            {
                case XlfKeys.isNotInWindowsPathFormat:
                    return "is not in Windows Path format";
                case XlfKeys.NotImplementedCasePublicProgramErrorPleaseContactDeveloper:
                    return "Not implemented case. public program error. Please contact developer";
                case XlfKeys.DifferentCountElementsInCollection:
                    return "Different count elements in collection";
                default:
                    ThrowEx.NotImplementedCase(k);
                    break;
            }

            return null;
        }
    }
}