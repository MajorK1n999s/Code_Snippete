using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.UI;

public class abc : MonoBehaviour
{
    string filepath;
    string str;
    string[] arr;

    public InputField ip1;
    public InputField ip2;
    public InputField ip3;

    private void Start()
    {
        filepath = Application.streamingAssetsPath + "/text.txt";
        str = File.ReadAllText(filepath);
        arr = str.Split("\n");

        foreach(string s in arr)
        {
            Debug.Log(s);
        }

    }

    public void UpdateFileText()
    {
        string newStr1 = ip1.text;
        string newStr2 = ip2.text;
        string newStr3 = ip3.text;

        string updateText = newStr1 + "\n" + newStr2 + "\n" + newStr3;

        File.WriteAllText(filepath, updateText);// WriteAlleText() this is use for add the new text removing old text;
        File.AppendAllText(filepath, "\n" + updateText);// AppendAllText() this use for add new text without remove old text;
        Debug.Log("update succesfully");
    }
}

