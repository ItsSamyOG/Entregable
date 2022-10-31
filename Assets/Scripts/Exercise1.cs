using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise1 : MonoBehaviour
{
    public TextMeshProUGUI textTMP;

    //Minimun number it can appear.
    private int Min = 0;
    //Mximum number it can apppear.
    private int Max = 50;

    // Create a function to generate a random number.
    public void RandomNumber()
    {
        // The value appears on the screen.
        textTMP.text = Random.Range(Min, Max).ToString();
    }
}
