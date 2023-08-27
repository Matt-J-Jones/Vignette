using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickToPickupItem : MonoBehaviour
{
    private bool canBeClicked = false;
    public playerInTrigger playerInTrigger;
    public GameObject collectableItem;
    public string newPdaMsg = "@";
    public GameObject PDAMessage;

    public GameObject playerInventory;
    public bool isKey;
    

    
    void Start()
    {
        playerInTrigger.OnPlayerEnterTrigger += HandlePlayerEnterTrigger;
        playerInTrigger.OnPlayerExitTrigger += HandlePlayerExitTrigger;
    }

    private void OnDestroy()
    {
        // Unsubscribe from the events to prevent memory leaks
        playerInTrigger.OnPlayerEnterTrigger -= HandlePlayerEnterTrigger;
        playerInTrigger.OnPlayerExitTrigger -= HandlePlayerExitTrigger;
    }

    private void HandlePlayerEnterTrigger()
    {
        canBeClicked = true;
    }

    private void HandlePlayerExitTrigger()
    {
        canBeClicked = false;
    }   

    public void OnMouseDown()
    {
        if (canBeClicked)
        {
            if (newPdaMsg != "@"){
                computerText textScript = PDAMessage.GetComponent<computerText>();
                textScript.GetComponent<Text>().text = "";
                textScript.currentCharIndex = 0;
                textScript.textToPrint = newPdaMsg;
            }

            if (isKey){
                inventoryTracker inventoryScript = playerInventory.GetComponent<inventoryTracker>();
                inventoryScript.collectedKeys += 1;
            }
            
            collectableItem.gameObject.SetActive(false);
        }
    }
}
