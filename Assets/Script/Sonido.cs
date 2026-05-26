using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sonido : MonoBehaviour
{
    public static Sonido instance;

    public AudioSource Main;

    public AudioMixer MixerFX;
    public AudioMixer MixerMusica;
    public AudioMixer MixerDialogos;

    public int id;

    void Awake()
    {
        float FXSave = PlayerPrefs.GetFloat("MixerFX", 1.0f);
        float MusicaSave = PlayerPrefs.GetFloat("MixerMusica", 1.0f);
        float DialogosSave = PlayerPrefs.GetFloat("MixerDialogos", 1.0f);
        CambioFX(FXSave);
        CambioDialogos(DialogosSave);
        CambioMusica(MusicaSave);

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void CambioFX(float volume)
    {
        if (volume < 0.0001f) volume = 0.0001f;
        float dB = Mathf.Log10(volume / 10) * 20f;
        MixerFX.SetFloat("FX Mixer", dB);
        PlayerPrefs.SetFloat("FXSave", volume);
    }
    public void CambioMusica(float volume)
    {
        if (volume < 0.0001f) volume = 0.0001f;
        float dB = Mathf.Log10(volume / 10) * 20f;
        MixerMusica.SetFloat("Musica Mixer", dB);
        PlayerPrefs.SetFloat("MusicaSave", volume);
    }
    public void CambioDialogos(float volume)
    {
        if (volume < 0.0001f) volume = 0.0001f;
        float dB = Mathf.Log10(volume / 10) * 20f;
        MixerDialogos.SetFloat("Dialogo Mixer", dB);
        PlayerPrefs.SetFloat("DialogosSave", volume);
    }
}
