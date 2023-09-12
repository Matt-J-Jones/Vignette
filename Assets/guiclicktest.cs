using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guiclicktest : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick()
    {
        if (gameObject.activeSelf){
            gameObject.SetActive(false);
        } else {
            gameObject.SetActive(true);
        }
    }
}
