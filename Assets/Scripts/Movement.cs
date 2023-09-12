using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveDistance = 0.1f;
    public float turnAngle = 15.0f;
    public bool isTurning;
    public GameObject microsubModel; 
    public bool canMove = false;
    public playerInTrigger playerInTrigger;

    
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
        canMove = true;
    }

    private void HandlePlayerExitTrigger()
    {
        canMove = false;
    }   

    public void OnMouseDown()
    {
        if (canMove && !isTurning)
        {
            microsubModel.transform.Translate(Vector3.forward * moveDistance);
        } else if (canMove && isTurning){
            microsubModel.transform.Rotate(Vector3.up, turnAngle);
        }
    }
}
