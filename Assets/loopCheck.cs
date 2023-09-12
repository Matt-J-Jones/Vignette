using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopCheck : MonoBehaviour
{
    public GameObject playerInventory;
    public int currentLoop;
    public GameObject EndCreditTrigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inventoryTracker inventoryScript = playerInventory.GetComponent<inventoryTracker>();
        currentLoop = inventoryScript.loopCount;
        if(currentLoop > 1){
            EndCreditTrigger.SetActive(true);
        }
    }
}
