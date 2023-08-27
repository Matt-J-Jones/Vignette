using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickDecryptMsg : MonoBehaviour
{
    private bool canBeClicked = false;
    public playerInTrigger playerInTrigger;
    public GameObject encryptedMessage;
    public GameObject decryptedMessage;
    public GameObject playerInventory;

    
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
        inventoryTracker inventoryScript = playerInventory.GetComponent<inventoryTracker>();
        int collectedKeys = inventoryScript.collectedKeys;

        if (canBeClicked)
        {
            encryptedMessage.gameObject.SetActive(false);
            decryptedMessage.gameObject.SetActive(true);
            inventoryScript.collectedKeys -= 1;
        }
    }
}
