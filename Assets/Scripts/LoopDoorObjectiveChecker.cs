using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoopDoorObjectiveChecker : MonoBehaviour
{
    public string nextLoop;
    public string successfulLoop;
    private string nextLevel;
    public GameObject objective;
    public playerInTrigger playerInTrigger;
    private bool canBeClicked = false;

    
    void Start()
    {
        playerInTrigger.OnPlayerEnterTrigger += HandlePlayerEnterTrigger;
        playerInTrigger.OnPlayerExitTrigger += HandlePlayerExitTrigger;
    }

    void Update()
    {
        if(objective.gameObject.activeSelf){
            nextLevel = successfulLoop;
        } else {
            nextLevel = nextLoop;
        }
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
            SceneManager.LoadScene(nextLevel);
        }
    }
}

