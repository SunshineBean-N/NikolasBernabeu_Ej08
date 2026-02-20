using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ValoresInput : MonoBehaviour
{
    public void CambioEscena(string nombreEscenas)
    {SceneManager.LoadScene(nombreEscenas);}
    // control cambios de escena, el nombre identifica pero no es la escena usada.

    [Header("Toggle")]
    public TMP_Text TextoValorToggle;

    public void LeerToggleEscrito(string toggle)
    { TextoValorToggle.text = toggle; }
        // Header pone un titulo dentro del inspector, el TMP_Text es el tipo que va a salir en el "circulo del cuadro", string es cadena de texto y le estas diciendo que ese valor.text es esa cadena de texto.
 
    [Header("InputField")]
    public TMP_InputField IdentificadorTexto;
    public TMP_Text textoEscrito;
    public void LeerField(string InputField)
    { IdentificadorTexto.text = InputField; }
}
