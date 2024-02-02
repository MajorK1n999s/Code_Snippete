using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{
    public InputField inptFldEnterCmd, inptFldFloorPlansCmd, inptFldImagesCmd, inptFldVideosCmd, inptFldBrochureCmd,
    inptFldLocationCmd, inptFldHomeCmd, inptFldBackCmd, inptFldLightsOnCmd, inptFldLightsOffCmd, inptFldBTDeviceName;

    private void OnEnable()
    {
        this.loadSettings();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void loadSettings()
    {
        inptFldEnterCmd.text = PlayerPrefs.GetString("EnterCMD");
        inptFldFloorPlansCmd.text = PlayerPrefs.GetString("FloorPlansCMD");
        inptFldImagesCmd.text = PlayerPrefs.GetString("ImagesCMD");
        inptFldVideosCmd.text = PlayerPrefs.GetString("VideosCMD");
        inptFldBrochureCmd.text = PlayerPrefs.GetString("BrochureCMD");
        inptFldLocationCmd.text = PlayerPrefs.GetString("LocationCMD");
        inptFldHomeCmd.text = PlayerPrefs.GetString("HomeCMD");
        inptFldBackCmd.text = PlayerPrefs.GetString("BackCMD");
        inptFldLightsOnCmd.text = PlayerPrefs.GetString("LightsOnCMD");
        inptFldLightsOffCmd.text = PlayerPrefs.GetString("LightsOffCMD");
        inptFldBTDeviceName.text = PlayerPrefs.GetString("BT_Device");
    }

    public void saveSettings()
    {
        PlayerPrefs.SetString("EnterCMD", inptFldEnterCmd.text);
        PlayerPrefs.SetString("FloorPlansCMD", inptFldFloorPlansCmd.text);
        PlayerPrefs.SetString("ImagesCMD", inptFldImagesCmd.text);
        PlayerPrefs.SetString("VideosCMD", inptFldVideosCmd.text);
        PlayerPrefs.SetString("BrochureCMD", inptFldBrochureCmd.text);
        PlayerPrefs.SetString("LocationCMD", inptFldLocationCmd.text);
        PlayerPrefs.SetString("HomeCMD", inptFldHomeCmd.text);
        PlayerPrefs.SetString("BackCMD", inptFldBackCmd.text);
        PlayerPrefs.SetString("LightsOnCMD", inptFldLightsOnCmd.text);
        PlayerPrefs.SetString("LightsOffCMD", inptFldLightsOffCmd.text);
        PlayerPrefs.SetString("BT_Device", inptFldBTDeviceName.text);
    }
}
