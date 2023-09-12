using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class loopUpdater : MonoBehaviour
{
    
    public int loopCounter = 0;
    public GameObject playerInventory;
    private TMPro.TextMeshProUGUI textMeshPro;

    // Start is called before the first frame update
    void Start()
    {
        inventoryTracker inventoryScript = playerInventory.GetComponent<inventoryTracker>();
        loopCounter = inventoryScript.loopCount;
        textMeshPro = GetComponent<TMPro.TextMeshProUGUI>();
        textMeshPro.text = "You have completed " + loopCounter + " Loops";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
