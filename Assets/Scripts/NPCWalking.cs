using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCWalking : MonoBehaviour
{
    public Rigidbody rb;
    public Animator Animator;
    public bool Walk = false;
    
    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude > 0.01f){
            Animator.SetBool("Walk", true);
            Walk = true;
        } else {
            Animator.SetBool("Walk", false);
            Walk = false;
        }
    }
}
