using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicaBarraVida : MonoBehaviour
{
    public int vidaMax;
    public float vidaActual;
    public Image imagenBarraVida;

    void Star()
    {
        vidaActual = vidaMax;
    }

    void Update()
    {
        RevisarVida();
        
        if (vidaActual <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    
    public void RevisarVida()
    {
        imagenBarraVida.fillAmount = vidaActual / vidaMax;
    }
}
