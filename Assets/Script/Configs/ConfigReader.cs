using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public static class ConfigReader
{
    public static List<Dictionary<string, string>> ReadConfigFile(string fileName)
    {
        string str = Resources.Load(fileName).ToString();
        string[] sLines;
        if (str.IndexOf("\r\n") > 0)
            sLines = str.Split(new string[] { "\r\n" }, StringSplitOptions.None);
        else
            sLines = str.Split(new string[] { "\n" }, StringSplitOptions.None);
        // Debug.Log(sLines.Length);
        List<Dictionary<string, string>> arrTexts = new List<Dictionary<string, string>>();
        string[] tableHead = null;
        int lineCount = sLines.Length;
        int fieldCount;
        string sLine; string s; string[] fields;
        Dictionary<string, string> pair;
        for (int j = 0; j < lineCount; j++)
        {
            // Debug.Log(sLine);
            sLine = sLines[j];
            s = sLine.Trim();
            if (!s.StartsWith("#") && !s.StartsWith("$")) //过滤注释行
            {
                if (CkeckEffectiveCharNum(s) > 0)
                {
                    if (tableHead == null)
                    {
                        tableHead = s.Split(new string[] { "\t" }, StringSplitOptions.None);
                    }
                    else
                    {
                        pair = new Dictionary<string, string>();
                        fields = s.Split(new string[] { "\t" }, StringSplitOptions.None);
                        fieldCount = fields.Length;
                        for (int i = 0; i < fieldCount; i++)
                        {
                            //Debug.Log(tableHead[i]);
                            if (i < fieldCount)
                            {
                                pair.Add(tableHead[i], System.Text.RegularExpressions.Regex.Unescape(fields[i]));
                            }
                            else
                            {
                                pair.Add(tableHead[i], "");
                            }
                        }
                        arrTexts.Add(pair);
                    }
                }
            }
        }
        return arrTexts;
    }
    //检测有效的字符数(非空格和非tab)
    private static int CkeckEffectiveCharNum(string str)
    {
        byte[] strBytes = System.Text.Encoding.UTF8.GetBytes(str);
        int retCount = 0;
        for (int i = 0; i < strBytes.Length; i++)
        {
            if (strBytes[i] != 0x09 && strBytes[i] != 0x20)
            {
                retCount++;
            }
        }
        return retCount;
    }
}
