using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise8 : MonoBehaviour
{
    public TMP_InputField username;
    public TextMeshProUGUI message;



    public void Username()
    {
        
        if (username)
        {
            // Displays the message on the screen.
            message.text = "Hello " + username.text + ", welcome to this amazing adventure!";
        }
    }
}
