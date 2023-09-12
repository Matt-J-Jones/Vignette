using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QUINNController : MonoBehaviour
{
    public GameObject playerInventory;
    public GameObject chapterController;
    public GameObject[] Quinns;
    public int loopCount;
    public int chapterCount;
    public GameObject quinnOne;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        inventoryTracker inventoryScript = playerInventory.GetComponent<inventoryTracker>();
        loopCount = inventoryScript.loopCount - 1;
        chapterTracker chapterScript = chapterController.GetComponent<chapterTracker>();
        chapterCount = chapterScript.chapterCount;
        
        if(loopCount > 1){
            quinnOne.gameObject.SetActive(false);
        } 

        if(chapterCount > 0){
            Quinns[chapterCount-1].SetActive(true);
        }
    }
}
