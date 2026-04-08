using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class SlingletoneMovidas : MonoBehaviour
{
    public static SlingletoneMovidas instance;

    private void Awake()
    {
        if (instance == null) //comprueba si existe la instancia (si es true)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); //No se destruye al cambiar de escena
        }
        else
        { instance = this; } //Si no (no es true) destruye el duplicado
    }
}
