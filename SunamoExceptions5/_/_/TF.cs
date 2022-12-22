using AsyncIO.FileSystem;
using System;
using System.Threading.Tasks;

namespace SunamoExceptions
{
    public partial class TF
    {
        public static Type type = typeof(TF);

        /// <summary>
        /// Nemůže se volat společně s .Result! viz. https://stackoverflow.com/a/65820543/9327173 Způsobí to deadlock! Musím to dělat přes ThisApp.async_
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static async Task<string> ReadAllTextAsync(string s)
        {
            return await AsyncFile.ReadAllTextAsync(s);
        }
    }
}
