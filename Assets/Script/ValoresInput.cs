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

   // public void BotonEscape()
    //{ if Input.GetKeyPressed(KeyCode.Escape)}

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

    [Header("Slider")]
    public Slider miSlider;
    public TMP_Text textoValorSlider;

    public void LeerValorSlider()
    { float valor = miSlider.value;
    textoValorSlider.text = valor.ToString();}

    [Header("Dropdown")]
    public TMP_Dropdown miDropdown;
    public TMP_Text textoValorDropdown;

    public void LeerDropdown()
    { float valor = miDropdown.value;
        textoValorDropdown.text = valor.ToString();}
}
