using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerDeactivate : MonoBehaviour
{
    public GameObject[] itemsToDeactivate;
    
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject obj in itemsToDeactivate){
            obj.SetActive(false);
        }
    }
}
