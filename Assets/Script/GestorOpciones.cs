using UnityEngine;

public class GestorOpciones : MonoBehaviour
{    public Animator JuegoEntrada;
    public Animator VideoEntrada;
    public Animator AudioEntrada;

    public int AnimacionSwitch;
    //Apunta al "numero" de el menu

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
}
