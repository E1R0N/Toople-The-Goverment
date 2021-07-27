using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogerArmas : MonoBehaviour
{
    public GameObject[] armas;

    public LogicaPersonaje1 logicaPersonaje1;

    public BoxCollider puñoBoxCol;
    public BoxCollider[] armasBoxCol;

    void Start()
    {
        DesactivarCollidersArmas();
    }

    
    void Update()
    {
        
    }

    public void ActivarArmas(int numero)
    {
        for (int i = 0; i < armas.Length; i++)
        {
            armas[i].SetActive(false);
        }
        armas[numero].SetActive(true);

        logicaPersonaje1.conArma = true;
    }

    public void ActivarCollidersArmas()
    {
        for (int i = 0; i < armasBoxCol.Length; i++)
        {
            if (logicaPersonaje1.conArma)
            {
                if(armasBoxCol[i] != null)
                {
                    armasBoxCol[i].enabled = true;
                }
            }
            else
            {
                puñoBoxCol.enabled = true;
            }
        }
    }

    public void DesactivarCollidersArmas()
    {
        for (int i = 0; i < armasBoxCol.Length; i++)
        {
            if(armasBoxCol[i] != null)
            {
                armasBoxCol[i].enabled = false;
            }
        }
        puñoBoxCol.enabled = false;
    }
}
