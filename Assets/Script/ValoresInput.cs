using System.Diagnostics.Contracts;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ValoresInput : MonoBehaviour

{
    [Header("Toggle")]
    public TMP_Text TextoValorToggle;

    public void LeerToggleEscrito(string toggle)
    { TextoValorToggle.text = toggle; }
    // Header pone un titulo dentro del inspector, el TMP_Text es el tipo que va a salir en el "circulo del cuadro", string es cadena de texto y le estas diciendo que ese valor.text es esa cadena de texto.

    [Header("SliderMusica")]
    public Slider miSlider1;
    public TMP_Text textoValorSlider1;

    [Header("SliderFx")]
    public Slider miSlider2;
    public TMP_Text textoValorSlider2;

    [Header("SliderBrillo")]
    public Slider miSlider4;
    public TMP_Text textoValorSlider4;

    [Header("ControldeBrillo")]
    public Image panelBrillo;


    void Start()
    {
        float brilloGuardado = PlayerPrefs.GetFloat("Brillo", 1f);
        CambiarBrillo(brilloGuardado);
    }

    public void CambioEscena(string nombreEscenas)
    {SceneManager.LoadScene(nombreEscenas);}
    // control cambios de escena, el nombre identifica pero no es la escena usada.

    public void SalirJuego()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else 
        Application.Quit();
#endif
    }
    //Para salir de editor

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SalirJuego();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CambioEscena("Menu Principal");
        }
        //Estoy añadiendo que dos teclas distintas hagan cosas distintas
    }

    public void LeerValorSliderMusica()
    {
        float valor = miSlider1.value;
        textoValorSlider1.text = valor.ToString();
    }

    public void LeerValorSliderFX()
    {
        float valor = miSlider2.value;
        textoValorSlider2.text = valor.ToString();
    }

    public void LeerValorSliderBrillo()
    {
        float valor = miSlider4.value;
        textoValorSlider4.text = valor.ToString();
    }


    //.value es para indicar que es un valor numerico, to string convierte el valor en texto
    // Dupicados para todos los Slider

    public void CambiarBrillo(float valor)
    {
        Color c = panelBrillo.color;
        c.a = 1f - valor / 100;
        panelBrillo.color = c;
    }
}
