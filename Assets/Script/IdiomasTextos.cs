using UnityEngine;
using TMPro;
using System;

public class IdiomasTextos : MonoBehaviour
{
    [Header("Titulos")]
    public TextMeshProUGUI botonTituloOpcionesText;

    public TextMeshProUGUI botonJuegoOpcionesText;
    public TextMeshProUGUI botonVideoOpcionesText;
    public TextMeshProUGUI botonAudioOpcionesText;
    public TextMeshProUGUI botonSalirOpcionesText;

    [Header("Juego")]
    public TextMeshProUGUI botonDificultadText;
    public TextMeshProUGUI botonFacilText;
    public TextMeshProUGUI botonMedioText;
    public TextMeshProUGUI botonDificilText;
    public TextMeshProUGUI botonIdiomaText;

    [Header("Video")]
    public TextMeshProUGUI botonBrilloText;
    public TextMeshProUGUI botonContrasteText;
    public TextMeshProUGUI botonResolucionText;

    [Header("Audio")]
    public TextMeshProUGUI botonSilenciarText;
    public TextMeshProUGUI botonVolumenGeneralText;
    public TextMeshProUGUI botonMusicaText;
    public TextMeshProUGUI botonFXText;
    public TextMeshProUGUI botonDialogoText;

    private int i = 0;

    private string[,] matrizIdiomas = new string[3, 18]
    {
        { "Opciones", "Juego", "Vídeo", "Audio", "Salir", "Dificultad", "Fácil", "Medio", "Dificil", "Idioma", "Brillo", "Contraste", "Resolución", "Silenciar", "Volumen general", "Música", "FX", "Diálogos" },
        { "Opcións", "Xogo", "Vídeo", "Son", "Saír", "Dificultade", "Fácil", "Media", "Difícil", "Idioma", "Brillo", "Contraste", "Resolución", "Silenciar", "Volume xeral", "Música", "Efectos", "Diálogo" },
        { "Options", "Game", "Options", "Sound", "Exit", "Difficul", "Easy", "Medium", "Hard", "Language", "Brightness", "Contrast", "Resolution", "Mute", "Overall Volume", "Music", "FX", "Dialogue" },
    };
    //cambiar todo esto para opciones
    //crear matriz por escena
    void Start()
    {
        int i = PlayerPrefs.GetInt("Idioma", 0);
        ActualizarTextos();
    }
    //Llamo a i con playerprefs para cambiar su estado, por defecto está en 0 y si cambia varia

    public void ActualizarTextos()
         {
        botonTituloOpcionesText.text = matrizIdiomas[i, 0];

        botonJuegoOpcionesText.text = matrizIdiomas[i, 1];
        botonVideoOpcionesText.text = matrizIdiomas[i, 2];
        botonAudioOpcionesText.text = matrizIdiomas[i, 3];
        botonSalirOpcionesText.text = matrizIdiomas[i, 4];

        botonDificultadText.text = matrizIdiomas[i, 5];
        botonFacilText.text = matrizIdiomas[i, 6];
        botonMedioText.text = matrizIdiomas[i, 7];
        botonDificilText.text = matrizIdiomas[i, 8];
        botonIdiomaText.text = matrizIdiomas[i, 9];

        botonBrilloText.text = matrizIdiomas[i, 10];
        botonContrasteText.text = matrizIdiomas[i, 11];
        botonResolucionText.text = matrizIdiomas[i, 12];

        botonSilenciarText.text = matrizIdiomas[i, 13];
        botonVolumenGeneralText.text = matrizIdiomas[i, 14];
        botonMusicaText.text = matrizIdiomas[i, 15];
        botonFXText.text = matrizIdiomas[i, 16];
        botonDialogoText.text = matrizIdiomas[i, 17];
    }

        public void Espanol()
          {
        i = 0;
        ActualizarTextos();
          }
        public void Galego()
        {
            i = 1;
            ActualizarTextos();
        }
        public void Ingles()
        {
            i = 2;
            ActualizarTextos();
        }

    public void MenuToggle(int index)
    {
        PlayerPrefs.SetInt("Idioma", index);
        PlayerPrefs.Save();
        ActualizarTextos();
        //guardar playerprefs despues de esto
    }
}
