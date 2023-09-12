using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QUINNExit : MonoBehaviour
{
    public GameObject targetObject;
    public GameObject objectToDeactivate;
    public GameObject missionObjectToDeactivate;
    public float movementSpeed = 2.0f;
    public Animator animator;
    private bool walking = false;
    private bool reachedTarget = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (targetObject.activeSelf && !reachedTarget)
        {
            transform.LookAt(targetObject.transform);

            if (animator != null)
            {
                walking = true;
                animator.SetBool("Walking", walking);
            }

            float step = movementSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetObject.transform.position, step);

            if (transform.position == targetObject.transform.position)
            {
                reachedTarget = true;

                if (objectToDeactivate != null)
                {
                    objectToDeactivate.SetActive(false);
                }

                if (missionObjectToDeactivate != null){
                    missionObjectToDeactivate.SetActive(false);
                }
            }
        }
        else
        {
            if (animator != null)
            {
                walking = false;
                animator.SetBool("Walking", walking);
            }
        }
    }
}
