using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickPushSwitch : MonoBehaviour
{
    private bool canBeClicked = false;
    private float switchPressed = 0.01f;
    private Vector3 relativePositionRed;
    public playerInTrigger playerInTrigger;
    public GameObject switchRed;
    public GameObject itemToChange;
    public bool CreateDestroy = true;

    public AudioClip switchSound;
    public AudioSource switchSource;
    
    void Start()
    {
        playerInTrigger.OnPlayerEnterTrigger += HandlePlayerEnterTrigger;
        playerInTrigger.OnPlayerExitTrigger += HandlePlayerExitTrigger;

        relativePositionRed = switchRed.transform.localPosition;
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
            switchRed.transform.localPosition = new Vector3(relativePositionRed.x, switchPressed, relativePositionRed.z); 
            if(CreateDestroy){
                itemToChange.gameObject.SetActive(true);
            }
            else {
                itemToChange.gameObject.SetActive(false);
            }
            switchSource.PlayOneShot(switchSound);
        }
    }
}
