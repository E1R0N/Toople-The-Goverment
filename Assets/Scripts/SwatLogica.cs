using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwatLogica : MonoBehaviour
{
    private Animator anim;
    public float x, y;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y); 
    }
}
