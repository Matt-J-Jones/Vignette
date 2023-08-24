using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decryptKeyGen : MonoBehaviour
{
    
    public int stringLength = 10;
    private const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-_=+[{]}|;:',<.>/?¡¢£¤¥¦§¨©ª«¬®¯°±²³´µ¶·¸¹º»¼½¾¿ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿ";
    private TMPro.TextMeshProUGUI textMeshPro;

    // Start is called before the first frame update
    void Start()
    {
        string randomString = GenerateRandomString(stringLength);

        string GenerateRandomString(int length)
        {
            char[] result = new char[length];
            for (int i = 0; i < length; i++)
            {
                int randomIndex = Random.Range(0, characters.Length);
                result[i] = characters[randomIndex];
            }
            return new string(result);
        }

        textMeshPro = GetComponent<TMPro.TextMeshProUGUI>();
        textMeshPro.text = randomString;
    }
}





    