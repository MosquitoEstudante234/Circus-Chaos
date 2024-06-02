using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Walkable : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject arrowTarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Vector3 finalPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        finalPosition.z = 0;
        Destroy(Instantiate(arrowTarget, finalPosition, arrowTarget.transform.rotation), 2);
        agent.SetDestination(finalPosition);
    }
}
