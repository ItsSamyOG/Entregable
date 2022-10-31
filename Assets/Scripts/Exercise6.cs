using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise6 : MonoBehaviour
{
    public GameObject cylinder;

    private Material cylinderColor;

    private void Start()
    {
        // Gets the material from the renderer component.
        cylinderColor = cylinder.GetComponent<Renderer>().material;
    }

    // According to the index from the dropdown, it assigns a color to the cylinder.
    public void CylinderColor(int index)
    {
        switch (index)
        {
            case 0:
                cylinderColor.color = Color.white;
                break;
            case 1:
                cylinderColor.color = Color.red;
                break;

            case 2:
                cylinderColor.color = Color.blue;
                break;

            case 3:
                cylinderColor.color = Color.black;
                break;

            case 4:
                cylinderColor.color = Color.yellow;
                break;

            
        }
    }
    
}
