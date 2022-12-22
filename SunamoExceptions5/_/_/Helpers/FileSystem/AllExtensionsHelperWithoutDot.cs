using SunamoException;
using SunamoExceptions;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

/// <summary>
/// Only in SunExc
/// </summary>
public class AllExtensionsHelperWithoutDot
{
    public static Dictionary<string, TypeOfExtension> allExtensionsWithoutDot = null;

    public static void Initialize()
    {
        var exts = RH.GetConsts(typeof(AllExtensions));
        Initialize(exts);
    }

    public static void Initialize(List<FieldInfo> exts)
    {
        if (allExtensionsWithoutDot == null)
        {
            allExtensionsWithoutDot = new Dictionary<string, TypeOfExtension>();

            AllExtensions ae = new AllExtensions();
            foreach (var item in exts)
            {
                string extWithDot = item.GetValue(ae).ToString();
                string extWithoutDot = extWithDot.Substring(1);
                var v1 = item.CustomAttributes.First();
                TypeOfExtension toe = (TypeOfExtension)v1.ConstructorArguments.First().Value;
                allExtensionsWithoutDot.Add(extWithoutDot, toe);
            }
        }
    }
}
