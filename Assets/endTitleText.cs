using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class endTitleText : MonoBehaviour
{
    public TMP_FontAsset[] fontList;
    private TMPro.TextMeshProUGUI textMeshPro; // The text component to display the printed text
    private float fontChangeTime = 0f;
    private TMP_FontAsset currentFont;
    public AudioClip letterChangeSound;
    public AudioSource letterAudioSource;

    void Start()
    {
        // Get the TextMeshProUGUI component attached to this GameObject
        
        textMeshPro = GetComponent<TMPro.TextMeshProUGUI>();
        textMeshPro.text = textMeshPro.text;
        currentFont = textMeshPro.font; // Set the initial font
        currentFont = fontList[Random.Range(0, fontList.Length)]; // Choose a random font from the list
        textMeshPro.font = currentFont;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            currentFont = fontList[Random.Range(0, fontList.Length)]; // Choose a random font from the list
            textMeshPro.font = currentFont;
            letterAudioSource.PlayOneShot(letterChangeSound);
        }
    }
}
