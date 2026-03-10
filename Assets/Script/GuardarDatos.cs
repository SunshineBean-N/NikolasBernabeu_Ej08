using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class GuardarDatos : MonoBehaviour
{
    void Start()
    {
        CargarTextos();
    }
    //Necesito que Cargar siempre se ejecute al empezar cada escena

    [Header("textos")]
    public TMP_InputField NombreJugador;
    public TMP_InputField Nombre;
    public TMP_InputField Apellidos;
    public TMP_InputField Correo;
    public TMP_InputField Edad;
    //Solo texto, uso TMP porque utilizo text mesh pro

    public void GuardarTextos()
    {
        PlayerPrefs.SetString("Jugador", NombreJugador.text);
        PlayerPrefs.SetString("Nombre", Nombre.text);
        PlayerPrefs.SetString("Apellidos", Apellidos.text);
        PlayerPrefs.SetString("Correo", Correo.text);
        PlayerPrefs.SetString("Edad", Edad.text);
        PlayerPrefs.Save();
    }
    public void CargarTextos()
    {
        string Jugador = PlayerPrefs.GetString("Jugador", "");
        NombreJugador.text = Jugador;

        string NombreN = PlayerPrefs.GetString("Nombre", "");
        Nombre.text = NombreN;

        string ApellidosA = PlayerPrefs.GetString("Apellidos", "");
        Apellidos.text = ApellidosA;

        string CorreoC = PlayerPrefs.GetString("Correo", "");
        Correo.text = CorreoC;

        string EdadE = PlayerPrefs.GetString("Edad", "");
        Edad.text = EdadE;
    }
}
