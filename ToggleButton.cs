using UnityEngine;
using UnityEngine.UI;

public class ToggleButton : MonoBehaviour
{
	//get a button ui and delete onClick event in the button.
	//add Toggle Componant.
    public Toggle LightsBTN; 

    private void Start()
    {
        // Subscribe to the onValueChanged event
        LightsBTN.onValueChanged.AddListener(OnLightsToggle);
    }

    private void OnLightsToggle(bool isOn)
    {
        if (isOn)
        {
            Debug.Log("Lights are ON");
        }
        else
        {
            Debug.Log("Lights are OFF");
        }
    }
}
