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
            Invoke("ReiniciarJuego", 2f);
        }
    }

    void ReinciarJuego ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void RevisarVida()
    {
        imagenBarraVida.fillAmount = vidaActual / vidaMax;
    }
}
