using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallsFallActivator : MonoBehaviour
{
    public GameObject targetObject;
    public string scriptName = "wallsFall";
    
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (targetObject != null)
            {
                MonoBehaviour scriptToActivate = targetObject.GetComponent(scriptName) as MonoBehaviour;
                if (scriptToActivate != null)
                {
                    scriptToActivate.enabled = true;
                }
                else
                {
                    Debug.LogError("Script '" + scriptName + "' not found on targetObject.");
                }
            }
        }
    }
}
