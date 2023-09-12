using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chapterTracker : MonoBehaviour
{
    
    static int chapterCountStatic;
    public int chapterCount;
    public bool titlecard = false;
    
    // Start is called before the first frame update
    void Start()
    {
        if (titlecard){
            chapterCountStatic += 1;
        }
        chapterCount = chapterCountStatic;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
