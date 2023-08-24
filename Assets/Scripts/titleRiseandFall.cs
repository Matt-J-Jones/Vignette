using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class titleRiseandFall : MonoBehaviour
{
    public float riseSpeed = 2f; // Speed at which the object rises
    public float pauseTime = 2f; // Time the object stays at the highest position
    public float fallSpeed = 2f; // Speed at which the object falls
    public float minY = -10f; // The lowest Y position
    public float maxY = 20f; // The highest Y position
    
    private float timer = 0f;
    private bool isRising = true;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new UnityEngine.Vector3(transform.position.x, minY, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
       if (isRising)
        {
            // Move the object upwards
            transform.Translate(UnityEngine.Vector3.up * riseSpeed * Time.deltaTime);

            // Check if the object has reached the highest position
            if (transform.position.y >= maxY)
            {
                isRising = false;
                timer = 0f; // Reset the timer when reaching the highest position
            }
        }
        else
        {
            // Increment the timer while the object is not rising
            timer += Time.deltaTime;

            // Check if it's time to start falling
            if (timer >= pauseTime)
            {
                // Move the object downwards
                transform.Translate(UnityEngine.Vector3.down * fallSpeed * Time.deltaTime);

                // Check if the object has reached the lowest position
                if (transform.position.y <= minY)
                {
                    // Deactivate the object when it reaches the lowest position
                    gameObject.SetActive(false);
                }
            }
        } 
    }
}
