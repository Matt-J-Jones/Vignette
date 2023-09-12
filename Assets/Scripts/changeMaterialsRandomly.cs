using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeMaterialsRandomly : MonoBehaviour
{
    public Material[] materials; // Array of materials to choose from
    public float minDelay = 0.5f;
    public float maxDelay = 1.0f;
    // public GameObject objectToChange;
    public GameObject[] objectsToChange;
    public AudioClip tickingSOund;
    
    public AudioSource tickingSource;
    public AudioSource tickingSourceBackup;

    void Start()
    {
        foreach(GameObject obj in objectsToChange)
        {
            StartCoroutine(ChangeWalls(obj.transform));
        }
        // StartCoroutine(ChangeWalls(objectToChange.transform));
    }

    private IEnumerator ChangeWalls(Transform parentTransform)
    {
        while(true){
            foreach (Transform child in parentTransform)
            {
                // Get a reference to the Renderer component (e.g., MeshRenderer)
                Renderer renderer = child.GetComponent<Renderer>();

                // Check if a Renderer component exists
                if (renderer != null)
                {
                    // Assign a random material from the materials array
                    int randomMaterialIndex = Random.Range(0, materials.Length);
                    renderer.material = materials[randomMaterialIndex];
                    
                }
            }
            if(!tickingSource.isPlaying){
                tickingSource.PlayOneShot(tickingSOund);
            } else {
                if(!tickingSourceBackup.isPlaying){
                    tickingSourceBackup.PlayOneShot(tickingSOund);
                }
            }

            float randomDelay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(randomDelay);
        }
    }
}
