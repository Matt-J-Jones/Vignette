using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class inventoryTracker : MonoBehaviour
{
    [Header("Decrypt Keys Tracker")]
    public int activeKeysInScene = 0;
    public int collectedKeys = 0;
    public GameObject[] decryptKeys;

    // Update is called once per frame
    void Update()
    {
        int count = 0;

        foreach(GameObject obj in decryptKeys){
            if(obj.activeSelf){
                count += 1;
            }
        }
        
        activeKeysInScene = count;
    }
}
