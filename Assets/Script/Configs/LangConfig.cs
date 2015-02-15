using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public static class LangConfig
{
    static Dictionary<string, string> dicLangs;
    static public string GetString(string key, params object[] values)
    {
        if (dicLangs == null)
        {
            dicLangs = new Dictionary<string, string>();
            //systemPost
            List<Dictionary<string, string>> listLang = ConfigReader.ReadConfigFile("Configs/lang");
            foreach (Dictionary<string, string> data in listLang)
            {
                string skey = data["key"];
                string value = data["value"];
                dicLangs.Add(skey, value);
            }
        }
        string ret = String.Format("Unkown language: {0}", key);
        if (dicLangs.ContainsKey(key))
        {
            ret = dicLangs[key];
            for (int i = 0; i < values.Length; i++)
            {
                string v = values[i].ToString();
                ret = ret.Replace(String.Format("&{0}", i + 1), v);
            }
        }
        return ret;
    }
}
