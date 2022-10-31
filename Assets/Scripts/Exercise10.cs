using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Exercise10 : MonoBehaviour
{
    public TextMeshProUGUI counter;

    private void Start()
    {
        // Reset counter to zero.
        counter.text = "0";
    }

    // Adds +1 to the score and updates the text.
    public void AddPoint()
    {
        //Declare a local variable.
        int score = 0;

        //Convert counter text to integer.
        int.TryParse(counter.text, out score);

        //Increment score.
        score++;

        //Convert score to text.
        counter.text = score.ToString();
    }
    // If the mouse is over the GameObject.
    private void OnMouseOver()
    {
        // If you Clicks on the sphera.
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // Add point to score.
            AddPoint();

            // Destroy the GameObject.
            Destroy(gameObject);
        }
    }
}
