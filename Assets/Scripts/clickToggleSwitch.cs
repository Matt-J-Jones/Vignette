using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickToggleSwitch : MonoBehaviour
{
    private bool canBeClicked = false;
    private bool switchStatus = false;
    private float switchInactive = 0.05f;
    private float switchPressed = 0.01f;
    private Vector3 relativePositionRed;
    private Vector3 relativePositionGreen;
    public playerInTrigger playerInTrigger;
    public GameObject switchGreen;
    public GameObject switchRed;
    public GameObject itemToTurnOn;

    
    void Start()
    {
        playerInTrigger.OnPlayerEnterTrigger += HandlePlayerEnterTrigger;
        playerInTrigger.OnPlayerExitTrigger += HandlePlayerExitTrigger;

        relativePositionRed = switchRed.transform.localPosition;
        relativePositionGreen = switchGreen.transform.localPosition;
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
            if(!switchStatus){
                switchRed.transform.localPosition = new Vector3(relativePositionRed.x, switchInactive, relativePositionRed.z); 
                switchGreen.transform.localPosition = new Vector3(relativePositionGreen.x, switchPressed, relativePositionGreen.z); 
                itemToTurnOn.gameObject.SetActive(true);
                switchStatus = true;
            } else {
                switchRed.transform.localPosition = new Vector3(relativePositionRed.x, switchPressed, relativePositionRed.z); 
                switchGreen.transform.localPosition = new Vector3(relativePositionGreen.x, switchInactive, relativePositionGreen.z); 
                itemToTurnOn.gameObject.SetActive(false);
                switchStatus = false;
            }
        }
    }
}
