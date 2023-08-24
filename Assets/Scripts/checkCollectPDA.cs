using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkCollectPDA : MonoBehaviour
{
    public GameObject PDAonHUD;
    public GameObject PDAtoCollect;

    // Update is called once per frame
    void Update()
    {
        if (!PDAtoCollect.activeSelf){
            PDAonHUD.gameObject.SetActive(true);
        }
    }
}
