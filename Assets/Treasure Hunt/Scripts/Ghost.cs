using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Ghost : MonoBehaviour
{
    public float followDistance = 20;

    // workshop - import player transform and navmesh agent
       

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player").transform;
        //agent = GetComponent<NavMeshAgent>();
        //agent.destination = agent.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // workshop - agent follow player
    }
}
