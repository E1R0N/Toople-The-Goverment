using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Message1 : MonoBehaviour
{
    public TextMesh medidor=new TextMesh();
    
    void OnCollisionEnter(Collision col){

        if (col.gameObject.tag == "personaje2"){

             medidor.text=("Hola!!! Estamos empezando una revolucion contra este gobierno tan dictador.");
             
        }
       
    }
    
    
}
