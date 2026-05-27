using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
public class GuardarOpciones : MonoBehaviour
{

    //Necesito que Cargar siempre se ejecute al empezar cada escena

    [Header("toggle")]
    public ToggleGroup Dificultad;
    public ToggleGroup Idiomas;
    public Toggle Mute;
    //Solo toggle, No consigo hacerlo a partir de aqui

    [Header("sliders")]
    public Slider Musica;
    public Slider FX;
    public Slider Brillo;
    //Solo Sliders

    [Header("Mixers")]
    public AudioMixer MixerFX;
    public AudioMixer MixerMusica;

    [Header("dropdown")]
    public TMP_Dropdown Resolucion;
    //DropDown

    [Header("ControldeBrillo")]
    public Image panelBrillo;
    void Start()
    {
        OpcionesCargar();

        float brilloGuardado = PlayerPrefs.GetFloat("Brillo", 1f);
        Brillo.value = brilloGuardado;
        CambiarBrillo(brilloGuardado);
        Brillo.onValueChanged.AddListener(CambiarBrillo);

        Musica.onValueChanged.AddListener(CambioMusica);
        FX.onValueChanged.AddListener(CambioFX);

    }

    public void OpcionesGuardar()
    {
        PlayerPrefs.SetFloat("Musica1", Musica.value);
        PlayerPrefs.SetFloat("FX1", FX.value);
        PlayerPrefs.SetFloat("Brillo1", Brillo.value);

        PlayerPrefs.Save();
    }
    public void OpcionesCargar()
    {
        //Sliders
        float musicaFondo = PlayerPrefs.GetFloat("Musica1", 1);
        Musica.value = musicaFondo;
        float soundEffect = PlayerPrefs.GetFloat("FX1", 1);
        FX.value = soundEffect;
        float brill = PlayerPrefs.GetFloat("Brillo1", 1);
        Brillo.value = brill;

        PlayerPrefs.Save();
    }

    public void CambiarBrillo(float valor)
    {
        Color c = panelBrillo.color;
        c.a = 1f - valor/100;
        panelBrillo.color = c;
        PlayerPrefs.SetFloat("Brillo", valor);
    }

    public void CambioFX(float volume)
    {
        if (volume < 0.0001f) volume = 0.0001f;
        float dB = Mathf.Log10(volume / 10) * 20f;
        MixerFX.SetFloat("FX Mixer", dB);
        PlayerPrefs.SetFloat("FXSave", volume);
        PlayerPrefs.Save();
    }
    public void CambioMusica(float volume)
    {
        if (volume < 0.0001f) volume = 0.0001f;
        float dB = Mathf.Log10(volume / 10) * 20f;
        Debug.Log(volume+" "+dB);
        MixerMusica.SetFloat("Musica Mixer", dB);
        PlayerPrefs.SetFloat("MusicaSave", volume);
        PlayerPrefs.Save();

    }
}
