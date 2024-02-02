using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSelectorScript : MonoBehaviour
{
    public static ButtonSelectorScript INSButtonSelectorScript;

    public List<GameObject> btnList = new List<GameObject>();
    private List<bool> btnStatusList = new List<bool>();
    public bool isBtnTextColorChange = false;
    private Color32 colBtnTextDefaultColor = new Color32(165, 136, 57, 255); // Yellow Color
    private Color32 colBtnTextSelectedColor = new Color32(255, 255, 255, 255); // White Color;
    public bool isBtnBGColorChange = false;
    private Color32 colBtnBGDefaultColor = new Color32(255, 255, 255, 255); // White Color
    private Color32 colBtnBGSelectedColor = new Color32(195, 152, 21, 255); // Yellow Color;
    public bool isBtnBGImgChange = false;
    public List<Sprite> btnBGDefaultSpriteList = new List<Sprite>();
    public List<Sprite> btnBGSelectedSpriteList = new List<Sprite>();
    private string btnSelectionMode = "One"; // One, Multiple, All
    private bool isBtnSelected = false;
    public GameObject lightsOnOffToggleButton;

    private void Awake()
    {
        INSButtonSelectorScript = this;
    }

    private void OnEnable()
    {
        this.setAllBtnTextColorDefault();
    }

    // Start is called before the first frame update
    void Start()
    {
        if (btnSelectionMode == "One")
        {
            this.setBtnStatusList();
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void setBtnStatusList()
    {
        btnStatusList.Clear();
        for (int i = 0; i < btnList.Count; i++)
        {
            btnStatusList.Add(false);
        }
    }

    public void changeButtonAttributes(int _btnIndex)
    {
        if (isBtnTextColorChange == true)
        {
            this.changeBtnTextColorAtribute(_btnIndex);
        }
        else if (isBtnBGColorChange == true)
        {
            this.changeBtnBGColorAtribute(_btnIndex);
        }
        else if (isBtnBGImgChange == true)
        {
            this.changeBtnBGImageAtribute(_btnIndex);
        }
    }

    /*
        ---------------------------------------------------------------------
    */
    /* Button Text Color Change */

    private void setAllBtnTextColorDefault()
    {
        foreach (GameObject btnObj in btnList)
        {
            btnObj.GetComponentInChildren<Text>().color = colBtnTextDefaultColor;
        }
    }

    private void setMultipleBtnTextColorSelected(int _btnIndex, bool _isBtnSelected)
    {
        switch (btnStatusList[_btnIndex])
        {
            case true:
                btnList[_btnIndex].GetComponentInChildren<Text>().color = colBtnTextDefaultColor;
                isBtnSelected = false;
                btnStatusList[_btnIndex] = isBtnSelected;
                break;
            case false:
                btnList[_btnIndex].GetComponentInChildren<Text>().color = colBtnTextSelectedColor;
                isBtnSelected = true;
                btnStatusList[_btnIndex] = isBtnSelected;
                break;
        }
    }

    private void setAllBtnTextColorSelected(bool _isBtnSelected)
    {
        foreach (GameObject btnObj in btnList)
        {
            switch (_isBtnSelected)
            {
                case true:
                    btnObj.GetComponentInChildren<Text>().color = colBtnTextDefaultColor;
                    isBtnSelected = false;
                    break;
                case false:
                    btnObj.GetComponentInChildren<Text>().color = colBtnTextSelectedColor;
                    isBtnSelected = true;
                    break;
            }
        }
    }

    private void changeBtnTextColorAtribute(int _btnIndex)
    {
        switch (btnSelectionMode)
        {
            case "One":
                this.setAllBtnTextColorDefault();
                btnList[_btnIndex].GetComponentInChildren<Text>().color = colBtnTextSelectedColor;
                break;
            case "Multiple":
                this.setMultipleBtnTextColorSelected(_btnIndex, isBtnSelected);
                break;
            case "All":
                this.setAllBtnTextColorSelected(isBtnSelected);
                break;
        }
    }

    /*
        ---------------------------------------------------------------------
    */
    /* Button BG Color Change */

    private void setAllBtnBGColorDefault()
    {
        foreach (GameObject btnObj in btnList)
        {
            btnObj.GetComponentInChildren<Image>().color = colBtnBGDefaultColor;
        }
    }

    private void setMultipleBtnBGColorSelected(int _btnIndex, bool _isBtnSelected)
    {
        switch (btnStatusList[_btnIndex])
        {
            case true:
                btnList[_btnIndex].GetComponentInChildren<Image>().color = colBtnBGDefaultColor;
                isBtnSelected = false;
                btnStatusList[_btnIndex] = isBtnSelected;
                break;
            case false:
                btnList[_btnIndex].GetComponentInChildren<Image>().color = colBtnBGSelectedColor;
                isBtnSelected = true;
                btnStatusList[_btnIndex] = isBtnSelected;
                break;
        }
    }

    private void setAllBtnBGColorSelected(bool _isBtnSelected)
    {
        foreach (GameObject btnObj in btnList)
        {
            switch (_isBtnSelected)
            {
                case true:
                    btnObj.GetComponentInChildren<Image>().color = colBtnBGDefaultColor;
                    isBtnSelected = false;
                    break;
                case false:
                    btnObj.GetComponentInChildren<Image>().color = colBtnBGSelectedColor;
                    isBtnSelected = true;
                    break;
            }
        }
    }

    private void changeBtnBGColorAtribute(int _btnIndex)
    {
        switch (btnSelectionMode)
        {
            case "One":
                this.setAllBtnBGColorDefault();
                btnList[_btnIndex].GetComponentInChildren<Image>().color = colBtnBGSelectedColor;
                break;
            case "Multiple":
                this.setMultipleBtnBGColorSelected(_btnIndex, isBtnSelected);
                break;
            case "All":
                this.setAllBtnBGColorSelected(isBtnSelected);
                break;
        }
    }

    /*
        ---------------------------------------------------------------------
    */
    /* Button BG Image Change */

    private void setAllBtnBGImageDefault()
    {
        int i = 0;
        foreach (GameObject btnObj in btnList)
        {
            btnObj.GetComponentInChildren<Image>().sprite = btnBGDefaultSpriteList[i];
            i++;
        }
    }

    private void setMultipleBtnBGImageSelected(int _btnIndex, bool _isBtnSelected)
    {
        switch (btnStatusList[_btnIndex])
        {
            case true:
                btnList[_btnIndex].GetComponentInChildren<Image>().sprite = btnBGDefaultSpriteList[_btnIndex];
                isBtnSelected = false;
                btnStatusList[_btnIndex] = isBtnSelected;
                break;
            case false:
                btnList[_btnIndex].GetComponentInChildren<Image>().sprite = btnBGSelectedSpriteList[_btnIndex];
                isBtnSelected = true;
                btnStatusList[_btnIndex] = isBtnSelected;
                break;
        }
    }

    private void setAllBtnBGImageSelected(bool _isBtnSelected)
    {
        int i = 0;
        foreach (GameObject btnObj in btnList)
        {
            switch (_isBtnSelected)
            {
                case true:
                    btnObj.GetComponentInChildren<Image>().sprite = btnBGDefaultSpriteList[i];
                    isBtnSelected = false;
                    break;
                case false:
                    btnObj.GetComponentInChildren<Image>().sprite = btnBGSelectedSpriteList[i]; ;
                    isBtnSelected = true;
                    break;
            }
            i++;
        }
    }

    private void changeBtnBGImageAtribute(int _btnIndex)
    {
        switch (btnSelectionMode)
        {
            case "One":
                this.setAllBtnBGImageDefault();
                btnList[_btnIndex].GetComponentInChildren<Image>().sprite = btnBGSelectedSpriteList[_btnIndex];
                break;
            case "Multiple":
                this.setMultipleBtnBGImageSelected(_btnIndex, isBtnSelected);
                break;
            case "All":
                this.setAllBtnBGImageSelected(isBtnSelected);
                break;
        }
    }

    /*
        ---------------------------------------------------------------------
    */
    /* All Lights On Off Toggle Button */

    private void setAllBtnTextColorSelected()
    {
        foreach (GameObject btnObj in btnList)
        {
            btnObj.GetComponentInChildren<Text>().color = colBtnTextSelectedColor;
        }
    }

    private void setAllBtnBGColorSelected()
    {
        foreach (GameObject btnObj in btnList)
        {
            btnObj.GetComponentInChildren<Image>().color = colBtnBGSelectedColor;
        }
    }

    private void setAllBtnBGImageSelected()
    {
        int i = 0;
        foreach (GameObject btnObj in btnList)
        {
            btnObj.GetComponentInChildren<Image>().sprite = btnBGSelectedSpriteList[i];
            i++;
        }
    }

    public void switchAllBtnSelectAndDeselect()
    {
        bool isLightsOn = lightsOnOffToggleButton.GetComponent<Toggle>().isOn;
        isBtnSelected = isLightsOn;
        switch (isLightsOn)
        {
            case true:
                Debug.Log("True Run...!");
                if (isBtnTextColorChange == true)
                {
                    this.setAllBtnTextColorSelected();
                }
                else if (isBtnBGColorChange == true)
                {
                    this.setAllBtnBGColorSelected();
                }
                else if (isBtnBGImgChange == true)
                {
                    this.setAllBtnBGImageSelected();
                }
                break;
            case false:
                Debug.Log("False Run...!");
                if (isBtnTextColorChange == true)
                {
                    this.setAllBtnTextColorDefault();
                }
                else if (isBtnBGColorChange == true)
                {
                    this.setAllBtnBGColorDefault();
                }
                else if (isBtnBGImgChange == true)
                {
                    this.setAllBtnBGImageDefault();
                }
                break;
        }
    }
}
