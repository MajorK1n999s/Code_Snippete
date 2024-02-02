using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageSwitcher : MonoBehaviour
{
    /// <summary>
    /// attached this script on empty gameObject and call custome fun() on Button
    /// </summary>
    

    public GameObject currentPanel;
    public GameObject[] panels;


    // Start is called before the first frame update
    void Start()
    {
        currentPanel = panels[0];   
    }

 
    public void PanelSwitcher(int newIndex)
    {
        if (newIndex < 0 || newIndex >= panels.Length)
        {
            Debug.Log("Out of Range");
            return;
        }

        if (currentPanel != null)
        {
            currentPanel.SetActive(false);
        }

        currentPanel = panels[newIndex];
        currentPanel.SetActive(true);
    }
}