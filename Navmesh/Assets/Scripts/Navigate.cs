using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Navigate : MonoBehaviour
{
    public Transform Target;
    NavMeshAgent agent;
    private void Start()
    {
        agent = transform.GetComponent<NavMeshAgent>();
    }
    // Update is called once per frame
    void Update()
    {
        agent.destination = Target.position;
    }
}
