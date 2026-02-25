using UnityEngine;

public class JestorMEnu : MonoBehaviour
{
    public bool controlPanel;
    public string nombreAnimacion;
    public Animator animator;
    //No se usa, primer codigo de animacion


    public Animator LogrosEntrada;
    public Animator CreditosEntrada;
    public Animator RecordsEntrada;
    public Animator TutorialEntrada;

    public int AnimacionSwitch;
    //Apunta al "numero" de el menu

    public void EntraMenus()
    {
        switch (AnimacionSwitch)
        { case 1:
                LogrosEntrada.Play("PanelLogrosEntrada");
                break;
        case 2:
                CreditosEntrada.Play("PanelMuestra");
                break;
        }
    }

    public void SalidaMenus()
    {
        switch (AnimacionSwitch)
        {
            case 1:
                LogrosEntrada.Play("PanelLogrosSalida");
                break;
            case 2:
                CreditosEntrada.Play("PanelMuestraSalida");
                break;
        }
    }

    //llamar con el onclick, asignar AnimationSwitch el valor uno e indicar que estoy en el metodo "EntraLogros"
    public void LogrosAnimacion()
    {
        SalidaMenus();
        AnimacionSwitch = 1;
        EntraMenus();
    }
    public void CreditosAnimacion()
    {
        SalidaMenus();
        AnimacionSwitch = 2;
        EntraMenus();
    }

    public void ControlAnimacion()
    {
        if (controlPanel) { nombreAnimacion = "nombrequecorresponda"; }
        else { nombreAnimacion = "laotraanimacion"; }
        animator.Play(nombreAnimacion);
        controlPanel = !controlPanel;
    }
    //No se usa, primer codigo de animacion

}
