using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise2 : MonoBehaviour
{
    public TextMeshProUGUI textTMP;
    public int number;

    void Update()
    {
        // If you press space key, verificate if the number is odd or even.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Divide the number by two and return thr remainder.
            if (number %2 ==0)
            {
                // The message appears on the screen.
                textTMP.text = "" + number + " is EVEN";
            }
            else
            {
                // The message appears on the screen.
                textTMP.text = "" + number + " is ODD";
            }
        }
    }
}
