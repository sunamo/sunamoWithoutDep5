using System;
using System.IO;

namespace SunamoExceptions
{
    public partial class FS
    {
        public static string GetExtension(string path)
        {
            return Path.GetExtension(path);
        }

        #region For easy copy from FSShared.cs
        private static void ThrowNotImplementedUwp()
        {
            ThrowEx.Custom("Not implemented in UWP");
        }

        public static string AbsoluteFromCombinePath(string arg)
        {
            throw new NotImplementedException();
        }

        public static object Combine(string upfolder, object p)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cant return with end slash becuase is working also with files
        /// </summary>
        /// <param name="FirstCharUpper"></param>
        /// <param name="s"></param>
        private static string CombineWorker(bool FirstCharUpper, params string[] s)
        {
            s = CA.TrimStart(AllChars.bs, s).ToArray();
            var result = Path.Combine(s);
            if (FirstCharUpper)
            {
                result = FS.FirstCharUpper(ref result);
            }
            else
            {
                result = FS.FirstCharUpper(ref result);
            }
            // Cant return with end slash becuase is working also with files
            //FS.WithEndSlash(ref result);
            return result;
        }

        public static string GetFileNameWithoutExtension(string s)
        {
            return GetFileNameWithoutExtension<string, string>(s, null);
        }



        /// <summary>
        /// Pokud by byla cesta zakončená backslashem, vrátila by metoda FS.GetFileName prázdný řetězec. 
        /// if have more extension, remove just one
        /// </summary>
        /// <param name="s"></param>
        public static StorageFile GetFileNameWithoutExtension<StorageFolder, StorageFile>(StorageFile s, AbstractCatalogBase<StorageFolder, StorageFile> ac)
        {
            if (ac == null)
            {
                var ss = s.ToString();
                var vr = Path.GetFileNameWithoutExtension(ss.TrimEnd(AllChars.bs));
                var ext = Path.GetExtension(ss).TrimStart(AllChars.dot);

                if (!SH.ContainsOnly(ext, RandomHelper.vsZnakyWithoutSpecial))
                {
                    if (ext != string.Empty)
                    {
                        return (dynamic)vr + AllStrings.dot + ext;
                    }
                }
                return (dynamic)vr;
            }
            else
            {
                ThrowNotImplementedUwp();
                return s;
            }
        }



        public static string GetDirectoryName(string rp)
        {
            if (string.IsNullOrEmpty(rp))
            {
                ThrowEx.IsNullOrEmpty(Exc.GetStackTrace(), type, "GetDirectoryName", "rp", rp);
            }
            if (!FS.IsWindowsPathFormat(rp))
            {
                ThrowEx.IsNotWindowsPathFormat("rp", rp);
            }


            rp = rp.TrimEnd(AllChars.bs);
            int dex = rp.LastIndexOf(AllChars.bs);
            if (dex != -1)
            {
                var result = rp.Substring(0, dex + 1);
                FS.FirstCharUpper(ref result);
                return result;
            }
            return "";
        }

        /// <summary>
        /// Use FirstCharUpper instead
        /// </summary>
        /// <param name="result"></param>
        private static string FirstCharUpper(ref string result)
        {
            if (IsWindowsPathFormat(result))
            {
                result = SH.FirstCharUpper(result);
            }
            return result;
        }

        /// <summary>
        /// Cant return with end slash becuase is working also with files
        /// Use this than FS.Combine which if argument starts with backslash ignore all arguments before this
        /// </summary>
        /// <param name="upFolderName"></param>
        /// <param name="dirNameDecoded"></param>
        public static string Combine(params string[] s)
        {
            return CombineWorker(true, s);
        }

        public static string WithEndSlash(ref string v)
        {
            if (v != string.Empty)
            {
                v = v.TrimEnd(AllChars.bs) + AllChars.bs;
            }
            FirstCharUpper(ref v);
            return v;
        }

        public static bool IsWindowsPathFormat(string argValue)
        {
            if (string.IsNullOrWhiteSpace(argValue))
            {
                return false;
            }

            bool badFormat = false;

            if (argValue.Length < 3)
            {
                return badFormat;
            }
            if (!char.IsLetter(argValue[0]))
            {
                badFormat = true;
            }



            if (char.IsLetter(argValue[1]))
            {
                badFormat = true;
            }

            if (argValue.Length > 2)
            {
                if (argValue[1] != '\\' && argValue[2] != '\\')
                {
                    badFormat = true;
                }
            }

            return !badFormat;
        }
        #endregion
    }
}
