﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

public class JsonConvert
{
    /// <summary>
    /// V první větvi vrátí List
    /// Každý element je poté Dictionary<string,object>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="v"></param>
    /// <returns></returns>
    public static T DeserializeObject<T>(string v)
    {
        return (T)JavascriptSerialization.utf8json.Deserialize(v, typeof(T));
    }

    public static string SerializeObject(object o)
    {
        return JavascriptSerialization.utf8json.Serialize(o);
    }

    public static string SerializeObject(object o, SunamoJson.Formatting indented, JsonSerializerSettings jsonSerializerSettings)
    {
        return JavascriptSerialization.utf8json.Serialize(o);
    }
}

namespace SunamoJson
{
    /// <summary>
    /// Must be in ns
    /// </summary>
    public enum Formatting
    {
        Indented
    }
}

public class JsonSerializerSettings
{
    public object NullValueHandling;
}