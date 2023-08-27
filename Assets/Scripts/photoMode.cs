using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class photoMode : MonoBehaviour
{
    public GameObject[] screenItemsToClear;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)){
            foreach (GameObject obj in screenItemsToClear){
                obj.gameObject.SetActive(false);
            }
        }
    }
}
