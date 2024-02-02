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

    public InputField IP1;
    public InputField IP2;
    public InputField IP3;

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

    public void _updateValue()
    {
        string str1 = IP1.text.ToString();

        File.WriteAllText(filepath, str1+"\n");
    }


}

