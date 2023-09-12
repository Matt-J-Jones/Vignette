using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeLab : MonoBehaviour
{
    public GameObject[] itemsToRemove;
    public GameObject[] itemsToAdd;
    public GameObject lightsToChange;
    public Material newLight;
    // Start is called before the first frame update
    void Start()
    {
        if(itemsToRemove != null){
            foreach(GameObject obj in itemsToRemove){
                obj.SetActive(false);
            }
        }

        if(itemsToRemove != null){
            foreach(GameObject obj in itemsToAdd){
                obj.SetActive(true);
            }
        }

        if(itemsToRemove != null){
            foreach (Transform child in lightsToChange.transform){
                Renderer renderer = child.GetComponent<Renderer>();
                renderer.material = newLight;
            }
        }
    }
}
