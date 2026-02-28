using UnityEngine;

public class GestorOpciones : MonoBehaviour
{    public Animator JuegoEntrada;
    public Animator VideoEntrada;
    public Animator AudioEntrada;

    public Animator AnimacionEsp;
    public Animator AnimacionGal;
    public Animator AnimacionIng;

    public bool IdiomaDesplegado = false;

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
            case 4:
                AnimacionEsp.Play("EspSeleccionado");
                break;
            case 5:
                AnimacionGal.Play("GalSeleccionado");
                break;
            case 6:
                AnimacionIng.Play("IngSeleccionado");
                break;
        }
    }

    public void DespliegaIdioma()
    {
        switch (AnimacionSwitch)
        {
            case 1:
                AnimacionEsp.Play("EspDesplegar");
                break;
            case 2:
                AnimacionGal.Play("GalDesplegar");
                break;
            case 3:
                AnimacionIng.Play("IngDesplegar");
                break;
        }
    }
    public void ContraeIdioma()
    {
        switch (AnimacionSwitch)
        {
            case 1:
                AnimacionEsp.Play("EspSeleccionado");
                break;
            case 2:
                AnimacionGal.Play("GalSeleccionado");
                break;
            case 3:
                AnimacionIng.Play("IngSeleccionado");
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


    // Al hacer los public void como lo anterior las animaciones no intereactuaban entre asi como deverian, porque no podian saber en que estado estan
    // Cree una bool para poder indicar a los botones si estan desplegados o no,
    // el if comprueba si la bool es true, al ser false pasa directamente al else y reproduce su animacion de desplegarse(Entrada),
    // al ser ahora true reproducira Seleccionado(Salida) (Se llama seleccionado porwur solo es esa bandera)

    public void EspAnimacion()
    {
        AnimacionSwitch = 1;
        if (IdiomaDesplegado)
        {
            ContraeIdioma();
            IdiomaDesplegado = false;
        } 
        else
        {
            DespliegaIdioma();
            IdiomaDesplegado = true;
        }
    }
    public void GalAnimacion()
    {
        AnimacionSwitch = 2;
        if (IdiomaDesplegado)
        {
            ContraeIdioma();
            IdiomaDesplegado = false;
        }
        else
        {
            DespliegaIdioma();
            IdiomaDesplegado = true;
        }
    }

    public void IngAnimacion()
    {
        AnimacionSwitch = 3;
        if (IdiomaDesplegado)
        {
            ContraeIdioma();
            IdiomaDesplegado = false;
        }
        else
        {
            DespliegaIdioma();
            IdiomaDesplegado = true;
        }
    }   
}
