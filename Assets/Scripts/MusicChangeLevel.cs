using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicChangeLevel : MonoBehaviour
{
    public AudioClip soundToPlay; // Reference to the sound clip
    private AudioSource audioSource;
    private bool soundPlaying = false;
    public string nextLevel;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = soundToPlay;
        audioSource.Play();
        soundPlaying = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (soundPlaying && !audioSource.isPlaying)
        {
            ChangeLevel();
        }
    }

    void ChangeLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
