using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaBryan : MonoBehaviour
{
    private Animator anim;
    public float x, y;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }
}
