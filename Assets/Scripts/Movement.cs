using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveDistance = 0.1f;
    public KeyCode forwardKey = KeyCode.W;

    private bool canMove = false;

    void Update()
    {
        if (Input.GetKeyDown(forwardKey))
        {
            canMove = true;
        }
        else if (Input.GetKeyUp(forwardKey))
        {
            canMove = false;
        }

        if (canMove)
        {
            transform.Translate(Vector3.forward * moveDistance);
            canMove = false;
        }
    }
}
