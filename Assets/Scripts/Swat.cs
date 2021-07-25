using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Swat : MonoBehaviour
{
    public GameObject Target;
    public NavMeshAgent agent;
    private Animator anim;
    public float x, y;

    public float distance;

    void Start()
    {
        anim = GetComponent<Animator>();
    } 
  
    void Update()
    {
        if (Vector3.Distance(Target.transform.position, transform.position)<distance)
        {
          agent.SetDestination(Target.transform.position);
          agent.speed= 5;
          y=1;
        }else
        {
          agent.speed=0;
          y=0;
        }
        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }

    
}
