using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace SunamoExceptions
{
    public partial class SH
    {
        /// <summary>
        /// Not auto remove empty
        /// </summary>
        /// <param name="p"></param>
        public static List<string> GetLines(string p)
        {
            List<string> vr = new List<string>();
            StringReader sr = new StringReader(p);
            string f = null;
            while ((f = sr.ReadLine()) != null)
            {
                vr.Add(f);
            }
            return vr;
        }

        /// <summary>
        /// Format - use string.Format with error checking, as only one can be use wich { } [ ] chars in text
        /// Format2 - use string.Format with error checking
        /// Format3 - Replace {x} with my code. Can be used with wildcard
        /// Format4 - use string.Format without error checking
        /// 
        /// Manually replace every {i} 
        /// </summary>
        /// <param name="template"></param>
        /// <param name="args"></param>
        public static string Format3(string template, params object[] args)
        {
            // this was original implementation but dont know why isnt used string.format
            for (int i = 0; i < args.Length; i++)
            {
                template = SH.ReplaceAll2(template, args[i].ToString(), AllStrings.lcub + i + AllStrings.rcub);
            }
            return template;
        }

            public static string WrapWithQm(string commitMessage)
        {
            return SH.WrapWith(commitMessage, AllChars.qm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string WrapWith(string value, char v, bool _trimWrapping = false)
        {
            // TODO: Make with StringBuilder, because of SH.WordAfter and so
            return WrapWith(value, v.ToString());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string WrapWith(string value, string h, bool _trimWrapping = false)
        {
            return h + SH.Trim(value, h) + h;
        }

        public static string TrimStart(string v, string s)
        {
            while (v.StartsWith(s))
            {
                v =  v.Substring(s.Length);
            }
            return v;
        }

        public static string TrimEnd(string name, string ext)
        {
            while (name.EndsWith(ext))
            {
                return name.Substring(0, name.Length - ext.Length);
            }
            return name;
        }

        public static string ReplaceOnce(string text, string xmlns, string empty)
        {
            throw new NotImplementedException();
        }

        public static string Trim(string s, string args)
        {
            s = TrimStart(s, args);
            s = TrimEnd(s, args);

            return s;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nazevPP"></param>
        /// <param name="only"></param>
        public static string FirstCharUpper(string nazevPP, bool only = false)
        {
            if (nazevPP != null)
            {
                string sb = nazevPP.Substring(1);
                if (only)
                {
                    sb = sb.ToLower();
                }
                return nazevPP[0].ToString().ToUpper() + sb;
            }
            return null;
        }


        /// <summary>
        /// If null, return Consts.nulled
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string NullToStringOrDefault(object n)
        {
            return NullToStringOrDefault(n, null);
        }

        /// <summary>
        /// If null, return Consts.nulled
        /// </summary>
        /// <param name="n"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public static string NullToStringOrDefault(object n, string v)
        {
            if (v == null)
            {
                if (n == null)
                {
                    v = Consts.nulled;
                }
                else
                {
                    v = n.ToString();
                }
            }
            if (n != null)
            {
                return AllStrings.space + v;
            }
            return " " + Consts.nulled;
        }

        /// <summary>
        /// Will be delete after final refactoring
        /// Automaticky o??e??e posledn?? znad A1
        /// Pokud m???? inty v A2, pou??ij metodu JoinMakeUpTo2NumbersToZero
        /// </summary>
        /// <param name="delimiter"></param>
        /// <param name="parts"></param>
        public static string Join(IEnumerable parts, object delimiter)
    {
            if (CA.Count(parts) == 0)
            {
                return string.Empty;
            }

            var d = delimiter.ToString();

            StringBuilder sb = new StringBuilder();
            foreach (var item in parts)
            {
            sb.Append(item.ToString() + d);
        }

        var vr = sb.ToString();
        return vr.Substring(0, vr.Length - d.Length);
    }

        public static List<string> Split(string parametry, params object[] deli)
        {
            return Split(StringSplitOptions.RemoveEmptyEntries, parametry, deli);
        }

        private static List<string> Split(StringSplitOptions removeEmptyEntries, string parametry, params object[] deli)
        {
            string[] sep = new string[deli.Length];
            for (int i = 0; i < sep.Length; i++)
            {
                sep[i] = deli[i].ToString();
            }
            return parametry.Split(sep, removeEmptyEntries).ToList() ;
        }

        public static string Format2(string status, params object[] args)
        {
            if (string.IsNullOrWhiteSpace(status))
            {
                return string.Empty;
            }
            if (status.Contains(AllChars.lcub) && !status.Contains("{0}"))
            {
                return status;
            }
            else
            {
                try
                {
                    return string.Format(status, args);
                }
                catch (Exception ex)
                {
                    ThrowEx.ExcAsArg(ex);
                    return status;
                }
            }
        }

    }
}
