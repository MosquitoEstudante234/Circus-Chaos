using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCFinder : MonoBehaviour
{
    public Transform target;
    public float moveSpeed = 5.0f;
    public float maxChaseDistance = 1000.0f;
    public float minChaseDistance = 1.0f;



    private void Start()
    {
        gameObject.transform.position = Playerlol.player.position;
    }

    private void Update()
    {
        if (target != null)
        {
            float distanceToTarget = Vector3.Distance(transform.position, target.position);

            if (distanceToTarget <= maxChaseDistance && distanceToTarget >= minChaseDistance)
            {
                Vector3 direction = target.position - transform.position;
                direction.Normalize();
                transform.position += direction * moveSpeed * Time.deltaTime;

            }
        }
    }
}