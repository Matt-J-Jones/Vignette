using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class readChapterStorage
{
    // Start is called before the first frame update
    public static bool[] chosenItems;

    public static void Initialize(int itemCount)
    {
        chosenItems = new bool[itemCount];
    }
}
