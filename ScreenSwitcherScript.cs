using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScreenSwitcherScript : MonoBehaviour
{
    public static ScreenSwitcherScript instanceScreenSwitcherScript;
    public List<GameObject> screenList; /* 0 - ... */
    private int settingsBtnClickCount = 0;
    
    /* Declare any required global variables if needed */

    private void Awake()
    {
        instanceScreenSwitcherScript = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        settingsBtnClickCount = 0;
        this.switchScreen(0);
    }

    // Update is called once per frame
    void Update() { }

    public void switchScreen(int _screenIndex)
    {
        for (int i = 0; i < screenList.Count; i++)
        {
            screenList[i].SetActive(false);
        }
        screenList[_screenIndex].SetActive(true);
    }

    public void switchSettingsScreen(int _settingsScreenIndex)
    {
        settingsBtnClickCount++;
        if (settingsBtnClickCount == 5)
        {
            for (int i = 0; i < screenList.Count; i++)
            {
                screenList[i].SetActive(false);
            }
            screenList[_settingsScreenIndex].SetActive(true);
            settingsBtnClickCount = 0;
        }
    }

    public void openPopUpUI(int _screenIndex)
    {
        screenList[_screenIndex].SetActive(true);
    }

    public void closePopUpUI(int _screenIndex)
    {
        screenList[_screenIndex].SetActive(false);
    }

    public void reloadApplication()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void loadNewScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }

}
