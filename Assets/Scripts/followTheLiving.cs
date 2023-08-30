using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followTheLiving : MonoBehaviour
{
    public Transform targetTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = targetTransform.position;
        transform.rotation = targetTransform.rotation;
    }
}
