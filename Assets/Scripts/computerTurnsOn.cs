using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class computerTurnsOn : MonoBehaviour
{
    public Material ComputerOff;
    public Material ComputerOn;
    public GameObject Desktop;
    public GameObject ComputerCanvas;

    // Update is called once per frame
    void Update()
    {
        if (ComputerCanvas.activeSelf){
            Desktop.GetComponent<Renderer>().material = ComputerOn;
        } else {
            Desktop.GetComponent<Renderer>().material = ComputerOff;
        }
    }
}
