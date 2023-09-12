using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkDecrypt : MonoBehaviour
{
    public GameObject encryptedMsg;
    public GameObject encryptedMsgWithButton;
    public GameObject decryptedMsg;

    public GameObject playerInventory;
    public int currentKeys;

    void Start()
    {
        
    }
    
    
    void Update()
    { 
        inventoryTracker inventoryScript = playerInventory.GetComponent<inventoryTracker>();
        // int collectedKeys = inventoryScript.collectedKeys;
        currentKeys = inventoryScript.collectedKeys;

        if (!decryptedMsg.activeSelf){
            if (inventoryScript.collectedKeys > 0){
                encryptedMsg.gameObject.SetActive(false);
                encryptedMsgWithButton.gameObject.SetActive(true);
            }
        }
    }
}
