using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaEnemigo : MonoBehaviour
{
    public int hp;
    public int dañoArma;
    public int dañoPuño;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "armaImpacto")
        {
            hp -= dañoArma;   
        }

        if (other.gameObject.tag == "golpeImpacto")
        {
            hp -= dañoPuño;   
        }

        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
    
}
