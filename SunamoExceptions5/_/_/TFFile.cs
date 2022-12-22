

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SunamoExceptions
{
    public partial class TF
    {
        #region For easy copy

        static bool LockedByBitLocker(string path)
        {
            return ThrowEx.LockedByBitLocker(path);
        }

        #region Array
        public static void WriteAllLinesArray(string path, string[] c)
        {
            WriteAllLines(path, c.ToList());
        }

        public static void WriteAllBytesArray(string path, byte[] c)
        {
            WriteAllBytes(path, c.ToList());
        }

        public static Byte[] ReadAllBytesArray(string path)
        {
            return TF.ReadAllBytes(path).ToArray();
        }
        #endregion

        #region Bytes
        /// <summary>
        /// Only one method where could be TF.ReadAllBytes
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static List<byte> ReadAllBytes(string file)
        {
            if (LockedByBitLocker(file))
            {
                return new List<byte>() ;
            }

            return File.ReadAllBytes(file).ToList();
        }
        public static void WriteAllBytes(string file, List<byte> b)
        {
            if (LockedByBitLocker(file))
            {
                return;
            }

            File.WriteAllBytes(file, b.ToArray());
        }
        #endregion

        #region Lines
        public static void WriteAllLines(string file, IList<string> lines)
        {
            if (LockedByBitLocker(file))
            {
                return;
            }

            File.WriteAllLines(file, lines.ToArray());
        }
        public static List<string> ReadAllLines(string file)
        {
            if (LockedByBitLocker(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }
        #endregion

        #region Text
        public static void WriteAllText(string path, string content)
        {
            if (LockedByBitLocker(path))
            {
                return;
            }

            File.WriteAllText(path, content);
        }

        public static string ReadAllText(string f)
        {
            if (LockedByBitLocker(f))
            {
                return String.Empty;
            }

            return File.ReadAllText(f);
        }
        #endregion
        #endregion
    }
}
