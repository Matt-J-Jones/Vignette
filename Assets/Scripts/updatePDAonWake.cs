using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updatePDAonWake : MonoBehaviour
{
    public string newPdaMsg = "@";
    public GameObject PDAMessage;
    void Start()
    {
        if (newPdaMsg != "@"){
                computerText textScript = PDAMessage.GetComponent<computerText>();
                textScript.GetComponent<Text>().text = "";
                textScript.currentCharIndex = 0;
                textScript.textToPrint = newPdaMsg;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
