using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openComputer : MonoBehaviour
{
    private bool canBeClicked = false;
    public playerInTrigger playerInTrigger;
    public GameObject PopupText;

    
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

    void Update()
    {
        if (canBeClicked && Input.GetKeyDown(KeyCode.Space))
        {
            PopupText.gameObject.SetActive(true);
        }
    }
}
