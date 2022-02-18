using System.IO;

namespace SunamoExceptions
{
    public partial class FS
    {
        #region For easy shared from FSShared.cs
        public static void DeleteFile(string item)
        {
            File.Delete(item);
        }

        /// <summary>
        /// Vrátí cestu a název souboru bez ext a ext
        /// All returned is normal case
        /// </summary>
        /// <param name="fn"></param>
        /// <param name="path"></param>
        /// <param name="file"></param>
        /// <param name="ext"></param>
        public static void GetPathAndFileNameWithoutExtension(string fn, out string path, out string file, out string ext)
        {
            path = Path.GetDirectoryName(fn) + AllChars.bs;
            file = FS.GetFileNameWithoutExtension(fn);
            ext = Path.GetExtension(fn);
        }

        public static string PathWithoutExtension(string path)
        {
            string path2, file, ext;
            FS.GetPathAndFileNameWithoutExtension(path, out path2, out file, out ext);
            return FS.Combine(path2, file);
        }

        public static string GetFullPath(string vr)
        {
            var result = Path.GetFullPath(vr);
            FS.FirstCharUpper(ref result);
            return result;
        }

        public static void FileToDirectory(ref string dir)
        {
            if (!dir.EndsWith(AllStrings.bs))
            {
                dir = FS.GetDirectoryName(dir);
            }
        }

        #endregion
    }
}