using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SunamoExceptions
{
    public partial class CA
    {
        #region For easy copy from CAShared64.cs
    /// <summary>
    /// Non direct edit
    /// </summary>
    /// <param name="backslash"></param>
    /// <param name="s"></param>
    public static List<string> TrimStart(char backslash, params string[] s)
    {
        return TrimStart(backslash, s.ToList());
    }

    /// <summary>
    /// Direct edit
    /// </summary>
    /// <param name="backslash"></param>
    /// <param name="s"></param>
    public static List<string> TrimStart(char backslash, List<string> s)
    {
        for (int i = 0; i < s.Count; i++)
        {
            s[i] = s[i].TrimStart(backslash);
        }
        return s;
    }

    /// <summary>
    /// element can be null, then will be added as default(T)
    /// Do hard cast
    /// If need cast to number, simply use CA.ToNumber
    /// If item is null, add instead it default(T)
    /// Simply create new list in ctor from A1
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="f"></param>
    public static List<T> ToList<T>(params T[] f)
    {
        if (f.Length == 0)
        {
            return new List<T>();
        }
        List<T> t= new List<T>(f.Length);
        foreach (var item in f)
        {
            t.Add(item);
        }
        return t;
    } 


    #endregion
    }
}
