using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise7 : MonoBehaviour
{
    public GameObject sphere;

    private Material sphereColor;

    private void Start()
    {
        // The material is goten from the renderer component.
        sphereColor = sphere.GetComponent<Renderer>().material;
    }

    // The transparency of the sphere changes with respect to the slider.
    public void SphereAlpha(float value)
    {
        sphereColor.color = new Vector4(sphereColor.color.r, sphereColor.color.g, sphereColor.color.b, value);
    }
}
