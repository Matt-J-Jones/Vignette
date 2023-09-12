using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shakeBuilding : MonoBehaviour
{
    public float minDelay = 0.5f;
    public float maxDelay = 1.0f;
    public float shakeAmount = 0.1f;
    public float shakeDuration = 0.2f;
    public GameObject objectToShake;
    public AudioClip explosionSound;
    public AudioSource explosionSource;

    void Start()
    {
        StartCoroutine(Shake(objectToShake));
    }

    // Update is called once per frame
    private IEnumerator Shake(GameObject objTransform)
    {
        while(true){  
            Vector3 originalPosition = objTransform.transform.localPosition;
            float elapsedTime = 0f;

            while (elapsedTime < shakeDuration)
            {
                float xOffset = Random.Range(-shakeAmount, shakeAmount);
                float yOffset = Random.Range(-shakeAmount, shakeAmount);

                objTransform.transform.localPosition = originalPosition + new Vector3(xOffset, yOffset, 0f);

                elapsedTime += Time.deltaTime;
                explosionSource.PlayOneShot(explosionSound);

                yield return null;
            }

            // Reset the object's position
            objTransform.transform.localPosition = originalPosition;
            float randomDelay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(randomDelay);
        }
    }
}
