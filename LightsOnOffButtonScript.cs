using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightsOnOffButtonScript : MonoBehaviour
{
    public GameObject lightsOnOffToggleButton;

    private void OnEnable()
    {
        lightsOnOffToggleButton.GetComponent<Toggle>().isOn = false;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void switchLightsOnOrOff()
    {
        bool isLightsOn = lightsOnOffToggleButton.GetComponent<Toggle>().isOn;
        switch (isLightsOn)
        {
            case true:
                ArduinoCommandSenderScript.INSArduinoCommandSenderScript.sendLightsOnArduinoCommand();
                break;
            case false:
                ArduinoCommandSenderScript.INSArduinoCommandSenderScript.sendLightsOffArduinoCommand();
                break;
        }
    }
}
