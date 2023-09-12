using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerActivateQUINN : MonoBehaviour
{
    public bool PlayerInTrigger = false;
    public GameObject[] itemsToActivate;
    public delegate void PlayerTriggerEventHandler();
    public event PlayerTriggerEventHandler OnPlayerEnterTrigger;
    public event PlayerTriggerEventHandler OnPlayerExitTrigger;

    void Update()
    {
        if(PlayerInTrigger){
            foreach (GameObject obj in itemsToActivate){
                obj.SetActive(true);
            }
            // Notify other scripts that the player entered the trigger zone.
            if (OnPlayerEnterTrigger != null) {
                OnPlayerEnterTrigger();
            }
        }else{
            // interactionBox.SetActive(false);
            // Notify other scripts that the player exited the trigger zone.
            if (OnPlayerExitTrigger != null) {
                OnPlayerExitTrigger();
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInTrigger = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInTrigger = false;
        }
    }  
}
