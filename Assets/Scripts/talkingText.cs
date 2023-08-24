using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talkingText : MonoBehaviour
{
    public string textToPrint = "";
    public float printSpeed = 0.05f; // The time delay between printing each character

    private TMPro.TextMeshProUGUI textMeshPro;
    private int currentCharIndex = 0; // The index of the current character being printed
    private float lastPrintTime = 0f; // The time of the last character print
    void Start()
    {
        // Get the Text component attached to this GameObject
        textMeshPro = GetComponent<TMPro.TextMeshProUGUI>();
        textToPrint = textMeshPro.text;
        textMeshPro.text = "";
    }

    void Update()
    {
        // If there are still characters to print and enough time has passed since the last print
        if (currentCharIndex < textToPrint.Length && Time.time - lastPrintTime > printSpeed)
        {
            // Get the next character to print
            char nextChar = textToPrint[currentCharIndex];

            // Add it to the printed text
            textMeshPro.text += nextChar;

            // Increment the current character index
            currentCharIndex++;

            // Update the last print time
            lastPrintTime = Time.time;
        }
    }
}
