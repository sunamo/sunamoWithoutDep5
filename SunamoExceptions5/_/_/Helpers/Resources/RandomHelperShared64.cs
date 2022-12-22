using System;
using System.Collections.Generic;
using System.Text;

namespace SunamoExceptions
{
    public partial class RandomHelper
    {
        #region For easy copy from RandomHelperShared64.cs
        
        public static List<char> vsZnaky = null;
        private static Random s_rnd = new Random();
        /// <summary>
        /// upper, lower and digits
        /// </summary>
        public static List<char> vsZnakyWithoutSpecial = null;
        static RandomHelper()
        {
            vsZnaky = new List<char>(AllChars.lowerChars.Count + AllChars.numericChars.Count + AllChars.specialChars.Count + AllChars.upperChars.Count);
            vsZnaky.AddRange(AllChars.lowerChars);
            vsZnaky.AddRange(AllChars.numericChars);
            vsZnaky.AddRange(AllChars.specialChars);
            vsZnaky.AddRange(AllChars.upperChars);

            vsZnakyWithoutSpecial = new List<char>(AllChars.lowerChars.Count + AllChars.numericChars.Count + AllChars.upperChars.Count);
            vsZnakyWithoutSpecial.AddRange(AllChars.lowerChars);
            vsZnakyWithoutSpecial.AddRange(AllChars.numericChars);
            vsZnakyWithoutSpecial.AddRange(AllChars.upperChars);
        }

        #endregion
    }
}
