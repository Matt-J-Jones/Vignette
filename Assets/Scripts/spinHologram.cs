using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinHologram : MonoBehaviour
{
    
    public float spinX = 0.0f;
    public float spinY = 0.0f;
    public float spinZ = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(spinX, spinY, spinZ) * Time.deltaTime);
    }
}
