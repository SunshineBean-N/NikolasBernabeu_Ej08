using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SoloVideo : MonoBehaviour
{
    [Header("ControldeBrillo")]
    public Image panelBrillo;

    void Start()
    {
        float brilloGuardado = PlayerPrefs.GetFloat("Brillo", 1f);
        CambiarBrillo(brilloGuardado);
    }

    public void CambiarBrillo(float valor)
    {
        Color c = panelBrillo.color;
        c.a = 1f - valor / 100;
        panelBrillo.color = c;
    }
    public void CambioEscena(string nombreEscenas)
    { SceneManager.LoadScene(nombreEscenas); }
    // control cambios de escena, el nombre identifica pero no es la escena usada

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CambioEscena("Menu Principal");
        }
        //Estoy añadiendo que dos teclas distintas hagan cosas distintas
    }
}
