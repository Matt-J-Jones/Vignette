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
    static int currentKeys = 0;

    [Header("Loop Manegment")]
    static int loopCountStatic = -1;
    public int loopCount = -1;
     public Material[] radialCracks;
     public GameObject brokenWindow;
     public int NMValue = 1;

    void Start()
    {
        collectedKeys = currentKeys;
        loopCountStatic += 1;
        loopCount = loopCountStatic;
        NMValue = loopCount;
        Debug.Log("Current Loop: " + loopCount);
        Debug.Log("Current Keys: " + collectedKeys);
    }
    // Update is called once per frame
    void Update()
    {
        currentKeys = collectedKeys;
        
        int count = 0;

        foreach(GameObject obj in decryptKeys){
            if(obj.activeSelf){
                count += 1;
            }
        }
        
        activeKeysInScene = count;
        
        if (radialCracks != null && NMValue < 10){
            Debug.Log("NM Value: " + NMValue);
            brokenWindow.GetComponent<Renderer>().material = radialCracks[NMValue];
        }
    }
}
