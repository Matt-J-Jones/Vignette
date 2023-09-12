using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class screenShake : MonoBehaviour
{
    [Header("Screenshake")]
    public CinemachineImpulseSource Impulse;
    public bool Explosion = true;   // Master switch to activate explosions
    public float waitTime = 2.0f;   // Initial wait time (in seconds)
    private float timer = 0.0f;     //Initial timer

    [Header("Sound")]
    public AudioClip ExplosionClip;
    public AudioSource Source;
    void Start()
    {
        
    }

    // Update is called once per frame
     void Update()
    {
        //Screenshake
        
        timer += Time.deltaTime;

        if (Explosion && timer > waitTime)
        
        {
            Impulse.GenerateImpulse();              
            Source.PlayOneShot(ExplosionClip);      
            timer = timer - waitTime;               
            waitTime = Random.Range(0.5f, 6.0f);   
        }
    }
}
