using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchDoors : MonoBehaviour
{
    public GameObject oldDoor;
    public GameObject newDoor;
    
    // Start is called before the first frame update
    void Start()
    {
        oldDoor.SetActive(false);
        newDoor.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
