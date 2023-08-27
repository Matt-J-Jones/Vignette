using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickToChat : MonoBehaviour
{
    private bool canBeClicked = false;
    public playerInTrigger playerInTrigger;
    public GameObject[] itemsToDeactivate;
    public GameObject[] itemsToActivate;
    
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
            foreach (GameObject obj in itemsToActivate){
                obj.gameObject.SetActive(true);
            }

            foreach (GameObject obj in itemsToDeactivate){
                obj.gameObject.SetActive(false);
            }
        }
    }
}
