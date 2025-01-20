using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void MultiJugador()
    {
        Debug.Log("Multijugador");
        SceneManager.LoadScene("Multijugador");
    }

    public void UnJugador()
    {
        Debug.Log("Un Jugador");
    }

    public void Salir()
    {
        Debug.Log("Alt + f4");
        Application.Quit();
    }
}
