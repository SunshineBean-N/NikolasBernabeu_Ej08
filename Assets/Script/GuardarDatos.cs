using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class GuardarDatos : MonoBehaviour
{
    [Header("textos")]
    public TMP_InputField NombreJugador;
    public TMP_InputField Nombre;
    public TMP_InputField Apellidos;
    public TMP_InputField Correo;
    public TMP_InputField Edad;
    //Solo texto, uso TMP porque utilizo text mesh pro

    [Header("toggle")]
    public int Dificultad;
    public int Idiomas;
    public bool Mute;
    //Solo toggle, No consigo hacerlo a partir de aqui

    [Header("sliders")]
    public float VolumenGeneral;
    public float Musica;
    public float FX;
    public float Dialogo;
    public float Brillo;
    public float Contraste;
    //Solo Sliders

    [Header("dropdown")]
    public int Resolucion;
    //DropDown

    public void Guardar()
    {
        PlayerPrefs.SetString("Jugador", NombreJugador.text);
        PlayerPrefs.SetString("Nombre", Nombre.text);
        PlayerPrefs.SetString("Apellidos", Apellidos.text);
        PlayerPrefs.SetString("Correo", Correo.text);
        PlayerPrefs.SetString("Edad", Edad.text);
        PlayerPrefs.Save();
    }

    public void Cargar()
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

    void Start()
    {
        Cargar();
    }
    //Necesito que Cargar siempre se ejecute al empezar cada escena
}
