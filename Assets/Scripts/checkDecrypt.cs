using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkDecrypt : MonoBehaviour
{
    public GameObject encryptedMsg;
    public GameObject encryptedMsgWithButton;
    public GameObject decryptedMsg;

    public GameObject decryptionKey;

    // Update is called once per frame
    void Update()
    {
        if (!decryptedMsg.activeSelf){
            if (!decryptionKey.activeSelf){
                encryptedMsg.gameObject.SetActive(false);
                encryptedMsgWithButton.gameObject.SetActive(true);
            }
        }
    }
}
