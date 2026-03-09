using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ValoresInput : MonoBehaviour
{
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


    [Header("Toggle")]
    public TMP_Text TextoValorToggle;

    public void LeerToggleEscrito(string toggle)
    { TextoValorToggle.text = toggle; }
        // Header pone un titulo dentro del inspector, el TMP_Text es el tipo que va a salir en el "circulo del cuadro", string es cadena de texto y le estas diciendo que ese valor.text es esa cadena de texto.
 
    [Header("InputField")]
    public TMP_InputField IdentificadorTexto;
    public TMP_Text textoEscrito;
    public void LeerField()
    {    string texto = IdentificadorTexto.text;
     IdentificadorTexto.text = texto; }
    // el primero identifica el marco, el segundo el texto que tu vas a escribir, (recuerda en el inspector en + añadir LeerField que es el nombre) entender porque no se escribe string en el parentesis **

    [Header("SliderVolumenGeneral")]
    public Slider miSlider;
    public TMP_Text textoValorSlider;

    [Header("SliderMusica")]
    public Slider miSlider1;
    public TMP_Text textoValorSlider1;

    [Header("SliderFx")]
    public Slider miSlider2;
    public TMP_Text textoValorSlider2;

    [Header("SliderDialogo")]
    public Slider miSlider3;
    public TMP_Text textoValorSlider3;

    [Header("SliderBrillo")]
    public Slider miSlider4;
    public TMP_Text textoValorSlider4;

    [Header("SliderContraste")]
    public Slider miSlider5;
    public TMP_Text textoValorSlider5;

    public void LeerValorVolumenGeneral()
    { float valor = miSlider.value;
    textoValorSlider.text = valor.ToString();}

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

    public void LeerValorSliderDialogo()
    {
        float valor = miSlider3.value;
        textoValorSlider3.text = valor.ToString();
    }

    public void LeerValorSliderBrillo()
    {
        float valor = miSlider4.value;
        textoValorSlider4.text = valor.ToString();
    }

    public void LeerValorSliderContraste()
    {
        float valor = miSlider5.value;
        textoValorSlider5.text = valor.ToString();
    }

    //.value es para indicar que es un valor numerico, to string convierte el valor en texto
    // Dupicados para todos los Slider

    [Header("Dropdown")]
    public TMP_Dropdown miDropdown;
    public TMP_Text textoValorDropdown;

    public void LeerDropdown()
    { float valor = miDropdown.value;
        textoValorDropdown.text = valor.ToString();}
}
