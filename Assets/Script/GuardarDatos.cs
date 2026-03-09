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
    public ToggleGroup Dificultad;
    public ToggleGroup Idiomas;
    public Toggle Mute;
    //Solo toggle, No consigo hacerlo a partir de aqui

    [Header("sliders")]
    public Slider VolumenGeneral;
    public Slider Musica;
    public Slider FX;
    public Slider Dialogo;
    public Slider Brillo;
    public Slider Contraste;
    //Solo Sliders

    [Header("dropdown")]
    public Dropdown Resolucion;
    //DropDown

    public void GuardarTextos()
    {
        PlayerPrefs.SetString("Jugador", NombreJugador.text);
        PlayerPrefs.SetString("Nombre", Nombre.text);
        PlayerPrefs.SetString("Apellidos", Apellidos.text);
        PlayerPrefs.SetString("Correo", Correo.text);
        PlayerPrefs.SetString("Edad", Edad.text);
        PlayerPrefs.Save();
    }

    public void GuardarOpciones()
    {
        PlayerPrefs.SetFloat("Volumen", VolumenGeneral.value);
        PlayerPrefs.SetFloat("Musica1", Musica.value);
        PlayerPrefs.SetFloat("FX1", FX.value);
        PlayerPrefs.SetFloat("Dialogo1", Dialogo.value);
        PlayerPrefs.SetFloat("Brillo1", Brillo.value);
        PlayerPrefs.SetFloat("Contraste1", Contraste.value);

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

    public void CargarOpciones()
    {
        //Toggles
        //PlayerPrefs.SetString("Volumen", VolumenGeneral.value);
        //PlayerPrefs.SetString("Nombre", Nombre.text);
        //int silencio = PlayerPrefs.GetInt("Silenciar");

        //Sliders
        float master = PlayerPrefs.GetFloat("Volumen", 1);
        VolumenGeneral.value = master;
        float musicaFondo = PlayerPrefs.GetFloat("Musica1", 1);
        Musica.value = musicaFondo;
        float soundEffect = PlayerPrefs.GetFloat("FX1", 1);
        FX.value = soundEffect;
        float voces = PlayerPrefs.GetFloat("Dialogo1", 1);
        Dialogo.value = voces;
        float brill = PlayerPrefs.GetFloat("Brillo1", 1);
        Brillo.value = brill;
        float contr = PlayerPrefs.GetFloat("Contraste1", 1);
        Contraste.value = contr;

        //Dropdowns
        //PlayerPrefs.SetString("Nombre", Nombre.text);

        PlayerPrefs.Save();
    }

    void Awake ()
    {
        CargarTextos();
        CargarOpciones();
    }
    //Necesito que Cargar siempre se ejecute al empezar cada escena
}
