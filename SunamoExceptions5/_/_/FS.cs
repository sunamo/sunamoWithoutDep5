using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SunamoExceptions
{
    public partial class FS
    {
        private static Type type = typeof(FS);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static string NormalizeExtension2(string item)
        {
            return item.ToLower().TrimStart(AllChars.dot);
        }
        public static bool IsFileHasKnownExtension(string relativeTo)
        {
            var ext = FS.GetExtension(relativeTo);
            ext = FS.NormalizeExtension2(ext);

            
            
            return AllExtensionsHelperWithoutDot.allExtensionsWithoutDot.ContainsKey(ext);
        }

        private static long ConvertToSmallerComputerUnitSize(long value, ComputerSizeUnits b, ComputerSizeUnits to)
        {
            return ConvertToSmallerComputerUnitSize(value, b, to);
        }


        public static bool? ExistsDirectoryNull(string d)
        {
            return Directory.Exists(d);
        }

        public static string GetSizeInAutoString(long value, ComputerSizeUnits b)
        {
            if (b != ComputerSizeUnits.B)
            {
                // Získám hodnotu v bytech
                value = ConvertToSmallerComputerUnitSize(value, b, ComputerSizeUnits.B);
            }


            if (value < 1024)
            {
                return value + " B";
            }

            double previous = value;
            value /= 1024;

            if (value < 1)
            {
                return previous + " B";
            }

            previous = value;
            value /= 1024;

            if (value < 1)
            {
                return previous + " KB";
            }

            previous = value;
            value /= 1024;
            if (value < 1)
            {
                return previous + " MB";
            }

            previous = value;
            value /= 1024;

            if (value < 1)
            {
                return previous + " GB";
            }

            return value + " TB";
        }


        public static List<string> GetFiles(string path, string v, SearchOption topDirectoryOnly)
        {
            return FS.GetFilesMoreMasc(path, v, topDirectoryOnly).ToList();
        }

        public static List<string> GetFilesMoreMasc(string path, string v, SearchOption topDirectoryOnly)
        {
            var c = AllStrings.comma;
            var sc = AllStrings.sc;
            List<string> result = new List<string>();
            List<string> masks = new List<string>();

            if (v.Contains(c))
            {
                masks.AddRange(SH.Split(v, c));
            }
            else if (v.Contains(sc))
            {
                masks.AddRange(SH.Split(v, sc));
            }
            else
            {
                masks.Add(v);
            }

            foreach (var item in masks)
            {
                result.AddRange(Directory.GetFiles(path, item, topDirectoryOnly));
            }

            return result;
        }

        public static string GetFileName(string file)
        {
            return Path.GetFileName(file);
        }

        public static void CreateUpfoldersPsysicallyUnlessThere(string nad)
        {
            CreateFoldersPsysicallyUnlessThere(FS.GetDirectoryName(nad));
        }

        /// <summary>
        /// Create all upfolders of A1 with, if they dont exist 
        /// </summary>
        /// <param name="nad"></param>
        public static void CreateFoldersPsysicallyUnlessThere(string nad)
        {
            ThrowEx.IsNullOrEmpty(Exc.GetStackTrace(), type, "CreateFoldersPsysicallyUnlessThere", "nad", nad);
            ThrowEx.IsNotWindowsPathFormat("nad", nad);

            FS.MakeUncLongPath(ref nad);
            if (FS.ExistsDirectory(nad))
            {
                return;
            }
            else
            {
                List<string> slozkyKVytvoreni = new List<string>();
                slozkyKVytvoreni.Add(nad);

                while (true)
                {
                    nad = FS.GetDirectoryName(nad);

                    // TODO: Tady to nefunguje pro UWP/UAP apps protoze nemaji pristup k celemu disku. Zjistit co to je UWP/UAP/... a jak v nem ziskat/overit jakoukoliv slozku na disku
                    if (FS.ExistsDirectory(nad))
                    {
                        break;
                    }

                    string kopia = nad;
                    slozkyKVytvoreni.Add(kopia);
                }

                slozkyKVytvoreni.Reverse();
                foreach (string item in slozkyKVytvoreni)
                {
                    string folder = FS.MakeUncLongPath(item);
                    if (!FS.ExistsDirectory(folder))
                    {
                        Directory.CreateDirectory(folder);
                    }
                }
            }
        }

        public static string ReadAllText(string filename)
        {
            return TF.ReadAllText(filename);
        }

        #region MyRegion


        private static void MakeUncLongPath(ref string nad)
        {

        }

        public static string MakeUncLongPath(string path)
        {
            return path;
        }

        private static bool ExistsDirectory(string nad)
        {
            return Directory.Exists(nad);
        }
        #endregion

        #region Just in SunamoExceptions
        public static void CreateFileIfDoesntExists(string path)
        {
            if (!File.Exists(path))
            {
                TF.WriteAllText(path, string.Empty);
            }
        }
        #endregion
    }
}