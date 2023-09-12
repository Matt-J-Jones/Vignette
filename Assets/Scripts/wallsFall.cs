using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallsFall : MonoBehaviour
{
    public float delayBetweenChildren = 0.5f;

    private void Start()
    {
        StartCoroutine(AddRigidbodiesWithDelay());
    }

    private IEnumerator AddRigidbodiesWithDelay()
    {
        foreach (Transform child in transform)
        {
            MeshCollider meshCollider = child.GetComponent<MeshCollider>();
            
            if (meshCollider != null)
            {
                meshCollider.enabled = false;
            }

            // Wait for the specified delay before adding the Rigidbody
            yield return new WaitForSeconds(delayBetweenChildren);

            Rigidbody rb = child.GetComponent<Rigidbody>();

            if (rb == null)
            {
                rb = child.gameObject.AddComponent<Rigidbody>();
                rb.useGravity = true;
                // Adjust other Rigidbody properties here if needed.
            }
        }
    }
}
