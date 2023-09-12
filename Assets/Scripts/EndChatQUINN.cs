using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndChatQUINN : MonoBehaviour
{
    private bool canBeClicked = false;
    public playerInTrigger playerInTrigger;
    public GameObject canvasObject;
    public GameObject QuinnExit;
    public GameObject NextQuinn;
    public string newPdaMsg = "@";
    public GameObject PDAMessage;

    
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
            if(NextQuinn != null){ NextQuinn.gameObject.SetActive(true); }
            
            canvasObject.gameObject.SetActive(false);
            QuinnExit.gameObject.SetActive(true);

            if (newPdaMsg != "@" && PDAMessage != null){
                computerText textScript = PDAMessage.GetComponent<computerText>();
                textScript.GetComponent<Text>().text = "";
                textScript.currentCharIndex = 0;
                textScript.textToPrint = newPdaMsg;
            }
        }
    }
}
