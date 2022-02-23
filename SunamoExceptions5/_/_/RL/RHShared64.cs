using SunamoExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SunamoException
{
    public partial class RH
    {
        #region For easy copy from RHShared64.cs
        #region Get types of class
        /// <summary>
        /// Return FieldInfo, so will be useful extract Name etc. 
        /// </summary>
        /// <param name="type"></param>
        public static List<FieldInfo> GetConsts(Type type, GetMemberArgs a = null)
        {
            if (a == null)
            {
                a = new GetMemberArgs();
            }
            IEnumerable<FieldInfo> fieldInfos = null;
            if (a.onlyPublic)
            {
                fieldInfos = type.GetFields(BindingFlags.Public | BindingFlags.Static |
                // return protected/public but not private
                BindingFlags.FlattenHierarchy).ToList();
            }
            else
            {
                ///fieldInfos = type.GetFields(BindingFlags.Static);//.Where(f => f.IsLiteral);
                fieldInfos = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic |
                  BindingFlags.FlattenHierarchy).ToList();

            }


            var withType = fieldInfos.Where(fi => fi.IsLiteral && !fi.IsInitOnly).ToList();
            return withType;
        }

       
        #endregion
        #endregion

         internal static string DumpAsString(string empty, object output)
        {
            string objectAsXmlString;

         System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(output.GetType());
         using (System.IO.StringWriter sw = new System.IO.StringWriter())
         {
            try
            {
               xs.Serialize(sw, output);
               objectAsXmlString = sw.ToString();
            }
            catch (Exception ex)
            {
               objectAsXmlString = ex.ToString();
            }
         }

         return objectAsXmlString;
        }
    }
}