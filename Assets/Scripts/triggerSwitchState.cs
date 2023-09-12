using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerSwitchState : MonoBehaviour
{
    public GameObject[] itemsToSwitch;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject obj in itemsToSwitch){
            if(obj.activeSelf){ obj.SetActive(false); } 
            else { obj.SetActive(true); } 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
