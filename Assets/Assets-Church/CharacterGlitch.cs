using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGlitch : MonoBehaviour
{
    public Material glitchMaterial;
    public float glitchInterval = 0.5f;
    public float glitchDuration = 0.2f;

    private float timeSinceLastGlitch = 0f;
    private float glitchTimer = 0f;

    private void Update()
    {
        timeSinceLastGlitch += Time.deltaTime;

        if (timeSinceLastGlitch >= glitchInterval)
        {
            glitchTimer += Time.deltaTime;
            glitchMaterial.SetFloat("_Intensity", 1.0f);

            if (glitchTimer >= glitchDuration)
            {
                glitchMaterial.SetFloat("_Intensity", 0.0f);
                glitchTimer = 0f;
                timeSinceLastGlitch = 0f;
            }
        }
    }
}
