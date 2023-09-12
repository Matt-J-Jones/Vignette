using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chapterControl : MonoBehaviour
{
    public GameObject[] titleCards;
    public GameObject finalChapter;
    static bool[] chosenItems;
    public bool[] chosenItemsPublic;
    
    // Start is called before the first frame update
    void Start()
    {
        if (chosenItems == null)
        {
            // Initialize the chosenItems array with the same length as titleCards
            chosenItems = new bool[titleCards.Length];
        }
        
        chosenItemsPublic = chosenItems;

        int randomIndex = GetRandomUnusedIndex();

        if (randomIndex >= 0)
        {
            titleCards[randomIndex].SetActive(true);
            chosenItems[randomIndex] = true;
        } else if (randomIndex == -1 && finalChapter != null){
            finalChapter.gameObject.SetActive(true);
        }
    }

    int GetRandomUnusedIndex()
    {
        int unusedCount = 0;

        for (int i = 0; i < chosenItems.Length; i++)
        {
            if (!chosenItems[i])
            {
                unusedCount++;
            }
        }

        if (unusedCount == 0)
        {
            return -1;
        }

        int randomIndex;
        do
        {
            randomIndex = Random.Range(0, chosenItems.Length);
        } while (chosenItems[randomIndex]);

        return randomIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
