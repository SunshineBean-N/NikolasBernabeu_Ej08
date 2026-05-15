using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GestorOpciones : MonoBehaviour
{ public Animator JuegoEntrada;
    public Animator VideoEntrada;
    public Animator AudioEntrada;

    public int AnimacionSwitch;
    //Apunta al "numero" de el menu


    [Header("Cambio de resolucion")]
    public TMP_Dropdown dropdownResolucion;
    public Toggle toggleModoPantalla;

    private int r;
    private int[][] resoluciones = new int[][]
    {
        new int[] { 1080, 1080 },
        new int[] { 1920, 1080 },
        new int[] {2560, 1440}
    };

    int modoPantalla;
    //Cosas de resolucion

    private void Start()
    {
        //Carga cambio de pantalla
        modoPantalla = PlayerPrefs.GetInt("Pantalla", 1);
        if (modoPantalla == 1) { toggleModoPantalla.isOn = true; }
        else { toggleModoPantalla.isOn = false; }

        //Carga cambio resolucion
        r = PlayerPrefs.GetInt("Resolucion", 1);
        dropdownResolucion.value = r;
        Resolucion();

    }

    public void EntraOpciones()
    {
        switch (AnimacionSwitch)
        {
            case 1:
                JuegoEntrada.Play("EntraJuego");
                break;
            case 2:
                VideoEntrada.Play("EntraVideo");
                break;
            case 3:
                AudioEntrada.Play("EntraAudio");
                break;

        }
    }

    public void SalidaOpciones()
    {
        switch (AnimacionSwitch)
        {
            case 1:
                JuegoEntrada.Play("SaleJuego");
                break;
            case 2:
                VideoEntrada.Play("SaleVideo");
                break;
            case 3:
                AudioEntrada.Play("SaleAudio");
                break;

        }
    }

    //llamar con el onclick, asignar AnimationSwitch el valor uno e indicar que estoy en el metodo "EntraLogros"
    //animaciones de paneles
    public void JuegoAnimacion()
    {
        SalidaOpciones();
        AnimacionSwitch = 1;
        EntraOpciones();
    }
    public void VideoAnimacion()
    {
        SalidaOpciones();
        AnimacionSwitch = 2;
        EntraOpciones();
    }
    public void AudioAnimacion()
    {
        SalidaOpciones();
        AnimacionSwitch = 3;
        EntraOpciones();
    }

    //Cambio de resolucion y guardado
    public void Resolucion()
    {
        int indice = dropdownResolucion.value;

        int ancho = resoluciones[indice][0];
        int alto = resoluciones[indice][1];

        if (toggleModoPantalla.isOn) { modoPantalla = 1; } else { modoPantalla = 0; }

        if (modoPantalla == 1) { toggleModoPantalla.isOn = true; } else { toggleModoPantalla.isOn = false; }

        FullScreenMode modo = toggleModoPantalla.isOn
            ? FullScreenMode.FullScreenWindow
            : FullScreenMode.Windowed;

        Screen.SetResolution(ancho, alto, modo);


        PlayerPrefs.SetInt("Resolucion", indice);
        PlayerPrefs.SetInt("Pantalla", modoPantalla);
        PlayerPrefs.Save();
    }
}
