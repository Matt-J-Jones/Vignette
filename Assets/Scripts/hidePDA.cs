using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hidePDA : MonoBehaviour
{
    public bool PDAOpen = true;
    public GameObject PDA;
    public Transform player;

    public AudioClip closePDA;
    public AudioClip openPDA;
    public AudioSource PDAAudioSource;
    public float PDAClosedY = 1.25f;
    private Vector3 relativePosition;
    // Start is called before the first frame update
    void Start()
    {
        relativePosition = PDA.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space))
         {
            PDAOpen = !PDAOpen;
            if (PDAOpen)
            {
                PDA.transform.localPosition = relativePosition;
                PDAAudioSource.PlayOneShot(openPDA);
            }
            else
            {
                PDA.transform.localPosition = new Vector3(relativePosition.x, PDAClosedY, relativePosition.z); 
                PDAAudioSource.PlayOneShot(closePDA);
            }
         }
    }
}
