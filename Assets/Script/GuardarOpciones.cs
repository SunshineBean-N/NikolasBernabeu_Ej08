using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Collections.Generic;
public class GuardarOpciones : MonoBehaviour
{
    void Start()
    {
        OpcionesCargar();
    }
    //Necesito que Cargar siempre se ejecute al empezar cada escena

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
    public TMP_Dropdown Resolucion;
    //DropDown

    public void OpcionesGuardar()
    {
        PlayerPrefs.SetFloat("Volumen", VolumenGeneral.value);
        PlayerPrefs.SetFloat("Musica1", Musica.value);
        PlayerPrefs.SetFloat("FX1", FX.value);
        PlayerPrefs.SetFloat("Dialogo1", Dialogo.value);
        PlayerPrefs.SetFloat("Brillo1", Brillo.value);
        PlayerPrefs.SetFloat("Contraste1", Contraste.value);

        PlayerPrefs.Save();
    }
    public void OpcionesCargar()
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
}
