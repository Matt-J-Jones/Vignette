using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickNextPage : MonoBehaviour
{
    private bool canBeClicked = false;
    public playerInTrigger playerInTrigger;
    public GameObject currentPage;
    public GameObject nextPage;

    
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
            nextPage.gameObject.SetActive(true);
            currentPage.gameObject.SetActive(false);
        }
    }
}
