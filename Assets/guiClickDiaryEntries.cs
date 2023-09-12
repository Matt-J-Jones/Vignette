using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guiClickDiaryEntries : MonoBehaviour
{
    public GameObject[] diaryEntries;

    
    public void OnClick()
    {
        foreach(GameObject obj in diaryEntries){
            obj.SetActive(false);
        }

        gameObject.SetActive(true);
    }
}
