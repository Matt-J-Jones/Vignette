using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_Controls : MonoBehaviour
{
     private CharacterController controller;
 
     public float speed = 6f;
     public float backwardSpeedMultiplier = 0.5f;
     public float turnSpeed = 90f;

     public bool turning = false;
     public bool cutscene = false;
 
     private void Start()
     {
         controller = GetComponent<CharacterController>();
     }
 
     private void Update()
     {
        
        if (!turning)
        {
            
            Vector3 movDir;
  
            float verticalInput = Input.GetAxis("Vertical");
            transform.Rotate(0, Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime, 0);
            
            if (verticalInput < 0)
            {
                movDir = transform.forward * verticalInput * speed * backwardSpeedMultiplier;
            }
            else
            {
                movDir = transform.forward * verticalInput * speed;
            }
    
            // moves the character in horizontal direction
            controller.Move(movDir * Time.deltaTime - Vector3.up * 0.1f);
        } else {
            
        }
     }

    void CheckTurning() 
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            turning = true;
        }

        else {
            turning = false;
        }
    }
 }