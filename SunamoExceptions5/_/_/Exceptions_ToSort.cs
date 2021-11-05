using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SunamoExceptions
{
    public partial class Exceptions
    {
        #region From easy copy from ExceptionsShared64.cs

        public static bool RaiseIsNotWindowsPathFormat;

        

        public static object NotImplementedMethod(string before)
        {
            return CheckBefore(before) + SunamoExceptionsNotTranslateAble.NotImplementedCasePublicProgramErrorPleaseContactDeveloper + ".";
        }

        
        

        public static object IsNotWindowsPathFormat(string before, string argName, string argValue)
        {
            if (RaiseIsNotWindowsPathFormat)
            {
                var badFormat = !FS.IsWindowsPathFormat(argValue);

                if (badFormat)
                {
                    return CheckBefore(before) + " " + argName + " " + sess.i18n(XlfKeys.isNotInWindowsPathFormat);
                }
            }

            return null;
        }


        public static string IsNullOrEmpty(string before, string argName, string argValue)
        {
            string addParams = null;

            if (argValue == null)
            {
                addParams = AddParams();
                return CheckBefore(before) + argName + " is null" + addParams;
            }
            else if (argValue == string.Empty)
            {
                addParams = AddParams();
                return CheckBefore(before) + argName + " is empty (without trim)" + addParams;
            }
            else if (argValue.Trim() == string.Empty)
            {
                addParams = AddParams();
                return CheckBefore(before) + argName + " is empty (with trim)" + addParams;
            }

            return null;
        }
        public static StringBuilder sbAdditionalInfoInner = new StringBuilder();
        public static StringBuilder sbAdditionalInfo = new StringBuilder();
        private static string AddParams()
        {
            sbAdditionalInfo.Insert(0, Environment.NewLine);
            sbAdditionalInfo.Insert(0, "Outer:");
            sbAdditionalInfo.Insert(0, Environment.NewLine);

            sbAdditionalInfoInner.Insert(0, Environment.NewLine);
            sbAdditionalInfoInner.Insert(0, "Inner:");
            sbAdditionalInfoInner.Insert(0, Environment.NewLine);

            var addParams = sbAdditionalInfo.ToString();
            var addParamsInner = sbAdditionalInfoInner.ToString();
            return addParams + addParamsInner;
        }

        #endregion
    }
}