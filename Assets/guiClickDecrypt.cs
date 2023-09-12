using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guiClickDecrypt : MonoBehaviour
{
    
    public GameObject playerInventory;
    public GameObject decryptedMessage;
    public GameObject encryptedMessage;

    public bool decrypted = false;
    // Start is called before the first frame update
    public void OnClick()
    {
        inventoryTracker inventoryScript = playerInventory.GetComponent<inventoryTracker>();
        encryptedMessage.gameObject.SetActive(false);
        decryptedMessage.gameObject.SetActive(true);
        inventoryScript.collectedKeys -= 1;
    }

    void Update()
    {
    }
}
