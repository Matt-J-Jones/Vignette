using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableMovement : MonoBehaviour
{
    public GameObject Player;
    public GameObject Animation;
    
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        Player.GetComponent<Tank_Controls >().cutscene = true;
        Animation.GetComponent<Move >().enabled = false;
    }
}