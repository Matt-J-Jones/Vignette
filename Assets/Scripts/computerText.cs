using UnityEngine;
using UnityEngine.UI; // Add this line to access the Text component

public class computerText : MonoBehaviour
{
    public string textToPrint = "";
    public float printSpeed = 0.1f; // The time delay between printing each character
    public float pauseDuration = 0.5f;
    public AudioClip letterSound;
    public AudioSource letterSoundSource;

    public GameObject receivingMsgLight;
    public Material inactiveMaterial;
    public Material receivingMaterial;


    private Text textComponent; // The Text component to display the printed text
    public int currentCharIndex = 0; // The index of the current character being printed
    private float lastPrintTime = 0f; // The time of the last character print
    private bool isPausing = false; // Flag to indicate if the script is currently pausing
    private float pauseStartTime = 0f; // Time when the pause started

    void Start()
    {
        // Get the Text component attached to this GameObject
        textComponent = GetComponent<Text>();
        textComponent.text = "";
    }

    void Update()
    {
        // If there are still characters to print and enough time has passed since the last print
        if (currentCharIndex < textToPrint.Length && !isPausing && Time.time - lastPrintTime > printSpeed)
        {
            receivingMsgLight.GetComponent<Renderer>().material = receivingMaterial;
            // Get the next character to print
            char nextChar = textToPrint[currentCharIndex];

            if (nextChar == '@')
            {
                // Start pausing
                isPausing = true;
                pauseStartTime = Time.time;
            } else {
                // Add it to the printed text
                textComponent.text += nextChar;
                letterSoundSource.PlayOneShot(letterSound);
                // Increment the current character index
                currentCharIndex++;
            }

            // Update the last print time
            lastPrintTime = Time.time;
        }

        if (isPausing && Time.time - pauseStartTime >= pauseDuration)
        {
            isPausing = false;
            currentCharIndex++;
        }

        if (currentCharIndex >= textToPrint.Length){
            receivingMsgLight.GetComponent<Renderer>().material = inactiveMaterial;
        }
    }
}
