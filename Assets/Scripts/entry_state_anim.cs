using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entry_state_anim : MonoBehaviour
{
    private Animator Animator;
    public string state;

    
    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
        Animator.SetBool(state, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
