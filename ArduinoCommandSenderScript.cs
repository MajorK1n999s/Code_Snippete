using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArduinoCommandSenderScript : MonoBehaviour
{
    public static ArduinoCommandSenderScript INSArduinoCommandSenderScript;

    private void Awake()
    {
        INSArduinoCommandSenderScript = this;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void send_SSSSS_Command()
    {
        /* Windows Arduino */
        SerialController.Instance.SendSerialMessage(PlayerPrefs.GetString("SSSSS_Command"));
        /* iOS BLE */
        BLEMessageSenderScript.INSBLEMessageSenderScript.sendBTMessage(PlayerPrefs.GetString("SSSSS_Command"));
        /* Android HC05 */
        BluetoothManager.Instance.SendBTMessage(PlayerPrefs.GetString("SSSSS_Command"));
    }

    public void sendHomeArduinoCommand()
    {
        /* Windows Arduino */
        SerialController.Instance.SendSerialMessage(PlayerPrefs.GetString("HomeCommand"));
        /* iOS BLE */
        BLEMessageSenderScript.INSBLEMessageSenderScript.sendBTMessage(PlayerPrefs.GetString("HomeCommand"));
        /* Android HC05 */
        BluetoothManager.Instance.SendBTMessage(PlayerPrefs.GetString("HomeCommand"));
    }

    public void sendBackArduinoCommand()
    {
        /* Windows Arduino */
        SerialController.Instance.SendSerialMessage(PlayerPrefs.GetString("BackCommand"));
        /* iOS BLE */
        BLEMessageSenderScript.INSBLEMessageSenderScript.sendBTMessage(PlayerPrefs.GetString("BackCommand"));
        /* Android HC05 */
        BluetoothManager.Instance.SendBTMessage(PlayerPrefs.GetString("BackCommand"));
    }

    public void sendLightsOnArduinoCommand()
    {
        /* Windows Arduino */
        SerialController.Instance.SendSerialMessage(PlayerPrefs.GetString("LightsOnCommand"));
        /* iOS BLE */
        BLEMessageSenderScript.INSBLEMessageSenderScript.sendBTMessage(PlayerPrefs.GetString("LightsOnCommand"));
        /* Android HC05 */
        BluetoothManager.Instance.SendBTMessage(PlayerPrefs.GetString("LightsOnCommand"));
    }

    public void sendLightsOffArduinoCommand()
    {
        /* Windows Arduino */
        SerialController.Instance.SendSerialMessage(PlayerPrefs.GetString("LightsOffCommand"));
        /* iOS BLE */
        BLEMessageSenderScript.INSBLEMessageSenderScript.sendBTMessage(PlayerPrefs.GetString("LightsOffCommand"));
        /* Android HC05 */
        BluetoothManager.Instance.SendBTMessage(PlayerPrefs.GetString("LightsOffCommand"));
    }

}
