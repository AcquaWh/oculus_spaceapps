using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenDoors : MonoBehaviour
{
    public GameObject puertas;

    public void AbrirPuerta()
    {
        puertas.GetComponent<Animator>().SetBool("character_nearby", true);
    }
    public void CambiarEscena()
    {
        SceneManager.LoadScene("Future2");
    }
    public void CambiarEscena2()
    {
        SceneManager.LoadScene("City");
    }
}
