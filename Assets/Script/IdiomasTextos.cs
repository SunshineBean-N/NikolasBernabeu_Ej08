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
    public TextMeshProUGUI botonResolucionText;

    [Header("Audio")]
    public TextMeshProUGUI botonSilenciarText;
    public TextMeshProUGUI botonVolumenGeneralText;
    public TextMeshProUGUI botonMusicaText;
    public TextMeshProUGUI botonFXText;
    public TextMeshProUGUI botonDialogoText;

    int i;

    private string[,] matrizIdiomas = new string[3, 17]
    {
        { "Opciones", "Juego", "Vídeo", "Audio", "Salir", "Dificultad", "Fácil", "Medio", "Dificil", "Idioma", "Brillo", "Resolución", "Silenciar", "Volumen general", "Música", "FX", "Diálogos" },
        { "Opcións", "Xogo", "Vídeo", "Son", "Saír", "Dificultade", "Fácil", "Media", "Difícil", "Idioma", "Brillo", "Resolución", "Silenciar", "Volume xeral", "Música", "Efectos", "Diálogo" },
        { "Options", "Game", "Options", "Sound", "Exit", "Difficul", "Easy", "Medium", "Hard", "Language", "Brightness", "Resolution", "Mute", "Overall Volume", "Music", "FX", "Dialogue" },
    };
    //cambiar todo esto para opciones
    //crear matriz por escena
    void Start()
    {
        i = PlayerPrefs.GetInt("Idioma", 0);
        ActualizarTextos();
    }
    //Llamo a i con playerprefs para cambiar su estado, por defecto está en 0 y si cambia varia

    public void ActualizarTextos()
         {
        PlayerPrefs.SetInt("Idioma", i);
        PlayerPrefs.Save();
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
        botonResolucionText.text = matrizIdiomas[i, 11];

        botonSilenciarText.text = matrizIdiomas[i, 12];
        botonVolumenGeneralText.text = matrizIdiomas[i, 13];
        botonMusicaText.text = matrizIdiomas[i, 14];
        botonFXText.text = matrizIdiomas[i, 15];
        botonDialogoText.text = matrizIdiomas[i, 16];
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

 
}
