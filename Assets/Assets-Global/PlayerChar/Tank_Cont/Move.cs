using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Animator Animator;
    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            Animator.SetBool("Walk", true);
        } else {
            Animator.SetBool("Walk", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Animator.SetBool("Back", true);
        } else {
            Animator.SetBool("Back", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Animator.SetBool("Left", true);
        } else {
            Animator.SetBool("Left", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Animator.SetBool("Right", true);
        } else {
            Animator.SetBool("Right", false);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Animator.SetBool("Button", true);
        } else {
            Animator.SetBool("Button", false);
        }


    }
}
