using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    // Posicions for random value.
    private float xPosition;
    private float yPosition;
    private float zPosition;

    // Ranges
    private float xRange = 8f;
    private float yRange = 5f;
    private float zRange = 6f;

    void Update()
    {
        // If you pressed enter key.
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // Generates random positions for the cube.
            xPosition = Random.Range(-xRange, xRange);
            yPosition = Random.Range(-yRange, yRange);
            zPosition = Random.Range(-zRange, zRange);

            // Move de cube to an random position.
            transform.position = new Vector3(xPosition, yPosition, zPosition);
        }
    }
}
