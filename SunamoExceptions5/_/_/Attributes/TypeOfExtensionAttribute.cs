using System;

namespace SunamoExceptions
{
    public class TypeOfExtensionAttribute : Attribute
    {
        public TypeOfExtension Type { get; set; }

        public TypeOfExtensionAttribute(TypeOfExtension toe)
        {
            Type = toe;
        }
    }
}