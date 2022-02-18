using System.Collections.Generic;

namespace SunamoExceptions
{
    public class DictionaryHelper
    {
        #region For easy copy from DictionaryHelperShared64.cs to SunamoExceptions
        /// <summary>
        /// Copy elements to A1 from A2
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        public static void CopyTo<T, U>(Dictionary<T, U> _d, KeyValuePair<T, U>[] array, int arrayIndex)
        {
            array = new KeyValuePair<T, U>[_d.Count - arrayIndex + 1];

            int i = 0;
            bool add = false;
            foreach (var item in _d)
            {
                if (i == arrayIndex && !add)
                {
                    add = true;
                    i = 0;
                }

                if (add)
                {
                    array[i] = new KeyValuePair<T, U>(item.Key, item.Value);
                }

                i++;
            }
        }

        public static void CopyTo<T, U>(List<KeyValuePair<T, U>> _d, KeyValuePair<T, U>[] array, int arrayIndex)
        {
            array = new KeyValuePair<T, U>[_d.Count - arrayIndex + 1];

            int i = 0;
            bool add = false;
            foreach (var item in _d)
            {
                if (i == arrayIndex && !add)
                {
                    add = true;
                    i = 0;
                }

                if (add)
                {
                    array[i] = new KeyValuePair<T, U>(item.Key, item.Value);
                }

                i++;
            }
        }

        #endregion

        public static void AddOrPlus<T>(Dictionary<T, long> sl, T key, long p)
        {
            if (sl.ContainsKey(key))
            {
                sl[key] += p;
            }
            else
            {
                sl.Add(key, p);
            }
        }

        #region For easy copy from DictionaryHelperShared.cs to SunamoExceptions
        /// <summary>
        /// If exists index A2, set to it A3
        /// if don't, add with A3
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="qs"></param>
        /// <param name="k"></param>
        /// <param name="v"></param>
        public static void AddOrSet<T1, T2>(IDictionary<T1, T2> qs, T1 k, T2 v)
        {
            if (qs.ContainsKey(k))
            {
                qs[k] = v;
            }
            else
            {
                qs.Add(k, v);
            }
        }
        #endregion
    }
}
