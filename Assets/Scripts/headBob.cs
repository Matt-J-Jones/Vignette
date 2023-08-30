using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headBob : MonoBehaviour
{
    public float bobFrequency = 2.0f;
    public float bobAmplitude = 0.1f; 
    public float midpoint = 0.8f;  

    private Vector3 initialPosition;
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        float waveSlice = Mathf.Sin(timer);
        if (Mathf.Abs(waveSlice) > 0.001f)
        {
            float translateChange = waveSlice * bobAmplitude;
            // float totalAxes = Mathf.Clamp01(Mathf.Abs(horizontalInput) + Mathf.Abs(verticalInput));
            float totalAxes = Mathf.Clamp01(Mathf.Abs(verticalInput));
            float totalAxesNormalized = totalAxes * 0.5f;

            // Apply the bobbing motion.
            transform.localPosition = new Vector3(initialPosition.x, midpoint + translateChange * totalAxesNormalized, initialPosition.z);
        }

        else
        {
            transform.localPosition = initialPosition;
        }

        timer += bobFrequency * Time.deltaTime;

        if (timer > Mathf.PI * 2)
        {
            timer -= Mathf.PI * 2;
        }
    }
}
