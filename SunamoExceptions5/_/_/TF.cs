using AsyncIO.FileSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoExceptions
{
    public partial class TF
    {
        public static Type type = typeof(TF);

        public static async Task<string> ReadAllTextAsync(string s)
        {
            return await AsyncFile.ReadAllTextAsync(s);
        }
    }
}