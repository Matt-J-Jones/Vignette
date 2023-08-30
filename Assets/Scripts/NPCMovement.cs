using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class NPCMovement : MonoBehaviour
{
    
    public Transform[] waypoints; // Reference to your waypoint GameObject
    private NavMeshAgent navMeshAgent;
    public float pauseDuration = 2.0f;
    private int currentWaypointIndex = 0;
    public Animator Animator;
  

    
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        Animator = GetComponent<Animator>();
        StartCoroutine(MoveToWaypointsCoroutine());
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private IEnumerator MoveToWaypointsCoroutine()
    {
        while (currentWaypointIndex < waypoints.Length)
        {
            Transform currentWaypoint = waypoints[currentWaypointIndex];
            navMeshAgent.SetDestination(currentWaypoint.position);
            Animator.SetBool("Look", false);
            Animator.SetBool("Walk", true);

            yield return new WaitUntil(() => !navMeshAgent.pathPending && navMeshAgent.remainingDistance < 0.1f);

            Animator.SetBool("Walk", false);
            Animator.SetBool("Look", true);
            yield return new WaitForSeconds(pauseDuration);

            currentWaypointIndex++;

            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
    }
}
