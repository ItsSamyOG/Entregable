using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4 : MonoBehaviour
{
    public GameObject sphere;

    // The size of the sphere changes with respect to the slider.
    public void ScaleObject(float value)
    {
        sphere.transform.localScale = new Vector3(value, value, value);
    }
}
