using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.UI;

public class abc : MonoBehaviour
{
    string filepath;
    string fileContents;
    string[] lines;

    public InputField replaceTextField1;
    public InputField replaceTextField2;
    public InputField replaceTextField3;

    private void Start()
    {
        filepath = Path.Combine(Application.streamingAssetsPath, "text.txt");

        try
        {
            // Read the contents of the text file
            fileContents = File.ReadAllText(filepath);
            lines = fileContents.Split('\n');

            // Set InputField values based on the lines in the text file
            if (lines.Length >= 3)
            {
                replaceTextField1.text = lines[0].Trim();
                replaceTextField2.text = lines[1].Trim();
                replaceTextField3.text = lines[2].Trim();
            }
        }
        catch (Exception e)
        {
            Debug.LogError("Error reading the file: " + e.Message);
        }
    }

    public void UpdateTextFile()
    {
        // Update lines based on InputField values
        lines[0] = replaceTextField1.text;
        lines[1] = replaceTextField2.text;
        lines[2] = replaceTextField3.text;

        // Join the lines back into a single string
        fileContents = string.Join("\n", lines);

        try
        {
            // Write the updated text back to the file
            File.WriteAllText(filepath, fileContents);
            Debug.Log("Text file updated successfully.");
        }
        catch (Exception e)
        {
            Debug.LogError("Error updating the file: " + e.Message);
        }
    }
}

