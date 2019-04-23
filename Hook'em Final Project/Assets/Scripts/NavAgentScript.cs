using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavAgentScript : MonoBehaviour
{
    public Transform target;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start ()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update ()
    {
        agent.SetDestination(target.position);

    }
}
