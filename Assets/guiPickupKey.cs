using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class guiPickupKey : MonoBehaviour
{
    public GameObject collectableItem;
     public string newPdaMsg = "@";
     public GameObject PDAMessage;
     public GameObject playerInventory;
    
    // Start is called before the first frame update
   

    // Update is called once per frame
    public void OnClick()
    {
        if (newPdaMsg != "@")
        {
            computerText textScript = PDAMessage.GetComponent<computerText>();
            textScript.GetComponent<Text>().text = "";
            textScript.currentCharIndex = 0;
            textScript.textToPrint = newPdaMsg;
        }

        inventoryTracker inventoryScript = playerInventory.GetComponent<inventoryTracker>();
        inventoryScript.collectedKeys += 1;
        collectableItem.gameObject.SetActive(false);
    }
}
