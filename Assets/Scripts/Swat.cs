using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Swat : MonoBehaviour
{
    public GameObject Target;
    public NavMeshAgent agent;

    public float distance;

    void Update()
    {
        if (Vector3.Distance(Target.transform.position, transform.position)<distance){
          agent.SetDestination(Target.transform.position);
          agent.speed= 4;
      }
      else{
          agent.speed=0;
      }
    }
}
