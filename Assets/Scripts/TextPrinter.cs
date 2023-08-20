using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class TextPrinter : MonoBehaviour
{
    public TMP_FontAsset[] fontList;
    private TMPro.TextMeshProUGUI textMeshPro; // The text component to display the printed text
    private float fontChangeTime = 0f;
    private TMP_FontAsset currentFont;
    public AudioClip[] letterChangeSoundList;
    public AudioSource letterAudioSource;

    void Start()
    {
        // Get the TextMeshProUGUI component attached to this GameObject
        
        textMeshPro = GetComponent<TMPro.TextMeshProUGUI>();
        textMeshPro.text = textMeshPro.text;
        currentFont = textMeshPro.font; // Set the initial font
        fontChangeTime = Time.time + Random.Range(0f, 1f);
    }

    void Update()
    {
        if (Time.time >= fontChangeTime)
        {
            currentFont = fontList[Random.Range(0, fontList.Length)]; // Choose a random font from the list
            textMeshPro.font = currentFont; // Apply the new font
            fontChangeTime = Time.time + Random.Range(0f, 1f); // Set the next font change time
            letterAudioSource.PlayOneShot(letterChangeSoundList[Random.Range(0, letterChangeSoundList.Length)]);
            // if(!letterAudioSource.isPlaying){
            //     letterAudioSource.PlayOneShot(letterChangeSoundList[Random.Range(0, letterChangeSoundList.Length)]);
            // }
        }
    }
}