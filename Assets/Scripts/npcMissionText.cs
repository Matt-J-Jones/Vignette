using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcMissionText : MonoBehaviour
{
    public bool hasMetPlayer = false;
    public bool hasCompletedObjective = false;
    public GameObject objectiveItem;
    public GameObject greetingText;
    public GameObject setMission;
    public GameObject finishMission;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!objectiveItem.activeSelf){
            hasCompletedObjective = true;
        }

        if (!greetingText.activeSelf){
            hasMetPlayer = true;
        }

        if (hasMetPlayer && hasCompletedObjective){
            setMission.gameObject.SetActive(false);
            finishMission.gameObject.SetActive(true);
        }
    }
}
