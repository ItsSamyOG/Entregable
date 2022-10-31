using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exercise9 : MonoBehaviour
{
    public Toggle lightSwitch;
    public GameObject pointLight;

    private void Start()
    {
        // If SwitchLight is on or off.
        SwitchLight(lightSwitch.isOn);
    }

    // Turn the light on and off.
    public void SwitchLight(bool isOn)
    {
        // If is ON
        if (isOn)
        {
            // Enable Point Light.
            pointLight.GetComponent<Light>().enabled = true;
        }
        else
        {
            // Disable Point Light.
            pointLight.GetComponent<Light>().enabled = false;
        }
    }
}
