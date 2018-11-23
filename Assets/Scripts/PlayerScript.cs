using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerScript : MonoBehaviour {

    //public GameObject target;

    public Transform target;
    public Transform[] targets;
    public NavMeshAgent agent;
    public int currentTarget = 0;

	// Use this for initialization
	void Start () {

        //NavMeshAgent agent = GetComponent<NavMeshAgent>();
        //agent.speed = 1;//このようにスクリプトからNavMeshのプロパティを変更できる。
        //agent.destination = target.transform.position;

        agent = GetComponent<NavMeshAgent>();
}
	
	// Update is called once per frame
	void Update () {

        agent.SetDestination(target.position);

        if(Vector3.Distance(transform.position, target.position) < 1)
        {
            if(currentTarget < targets.Length - 1)
            {
                currentTarget += 1;
            }
            else
            {
                currentTarget = 0;
            }

        }

        target = targets[currentTarget];

        if(target != null)
        {
            agent.SetDestination(target.position);
        }
		
	}
}
