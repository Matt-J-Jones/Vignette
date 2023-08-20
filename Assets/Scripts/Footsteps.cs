using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioClip[] footstepSounds;
    public float footstepInterval = 0.5f;

    private AudioSource audioSource;
    private bool isPlaying = false;
    private float nextFootstepTime = 0.0f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (isPlaying && !audioSource.isPlaying)
        {
            isPlaying = false;
        }

        if (Input.GetKeyDown(KeyCode.W) && !isPlaying && Time.time >= nextFootstepTime)
        {
            // Randomly select a footstep sound
            AudioClip footstepSound = footstepSounds[Random.Range(0, footstepSounds.Length)];

            // Play the footstep sound
            audioSource.clip = footstepSound;
            audioSource.Play();

            // Update next footstep time
            nextFootstepTime = Time.time + footstepInterval;

            // Mark as playing
            isPlaying = true;
        }
    }
}
