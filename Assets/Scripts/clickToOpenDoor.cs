using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class clickToOpenDoor : MonoBehaviour
{
    public GameObject doorToOpen;
    public GameObject trigger;
    public GameObject intBox;
    public playerInTrigger playerInTrigger;
    public float targetRotationX = 0f;
    public float targetRotationY = 0f;
    public float targetRotationZ = 0f;
    private bool canBeClicked = false;
    private bool isDoorOpening = false;
    public AudioSource doorSource;
    public AudioClip doorClip;



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
        if (canBeClicked && !isDoorOpening)
        {
            StartCoroutine(OpenDoor());
            trigger.gameObject.SetActive(false);
            intBox.gameObject.SetActive(false);
        }
    }

    private IEnumerator OpenDoor()
    {
        isDoorOpening = true;
        doorToOpen.transform.Rotate(new UnityEngine.Vector3(targetRotationX, targetRotationY, targetRotationZ));
        doorSource.PlayOneShot(doorClip);
        isDoorOpening = false;
        yield return null;
    }
}
