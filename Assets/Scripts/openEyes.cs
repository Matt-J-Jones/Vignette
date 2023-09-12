using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openEyes : MonoBehaviour
{
     public Camera playerCamera;
    public float openingSpeed = 1.0f;
    public float maxFOV = 60.0f;

    private float currentFOV = 0.0f;

    void Update()
    {
        if (currentFOV < maxFOV)
        {
            currentFOV += openingSpeed * Time.deltaTime;
            currentFOV = Mathf.Clamp(currentFOV, 0.0f, maxFOV);
            playerCamera.fieldOfView = currentFOV;
        }
    }
}
