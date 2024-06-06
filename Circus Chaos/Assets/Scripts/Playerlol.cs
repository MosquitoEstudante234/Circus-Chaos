using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Playerlol : MonoBehaviour
{
    NavMeshAgent agent;
    //public Transform target;
    public static Transform player;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateUpAxis = false;
        agent.updateRotation = false;
        player = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //agent.SetDestination(target.position);
    }
}
