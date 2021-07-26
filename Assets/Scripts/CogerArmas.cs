using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogerArmas : MonoBehaviour
{
    public BoxCollider puñoBoxCol;

    void Start()
    {
        DesactivarCollidersArmas();
    }

    
    void Update()
    {
        
    }

    public void ActivarCollidersArmas()
    {
        puñoBoxCol.enabled = true;
    }

    public void DesactivarCollidersArmas()
    {
        puñoBoxCol.enabled = false;
    }
}
