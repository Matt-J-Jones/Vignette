using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickCloseOpen : MonoBehaviour
{
    public GameObject itemToDeactivate;
    public GameObject itemToActivate;
    public playerInTrigger playerInTrigger;
    private bool canBeClicked = false;



    // Update is called once per frame
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
        if(canBeClicked){
            if(itemToActivate != null) { itemToActivate.SetActive(true); }
            if(itemToDeactivate != null) { itemToDeactivate.SetActive(false); }
        }
        
    }
}
