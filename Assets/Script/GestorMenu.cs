using UnityEngine;

public class JestorMenu : MonoBehaviour
{
    public Animator LogrosEntrada;
    public Animator CreditosEntrada;
    public Animator RecordsEntrada;
    public Animator TutorialEntrada;
    public Animator SalirlEntrada;

    public int AnimacionSwitch;
    //Apunta al "numero" de el menu

    public void EntraMenus()
    {
        switch (AnimacionSwitch)
        { case 1:
                LogrosEntrada.Play("EntraLogros");
                break;
        case 2:
                CreditosEntrada.Play("EntraCreditos");
                break;
        case 3:
                RecordsEntrada.Play("EntraRecords");
                break;
        case 4:
                TutorialEntrada.Play("EntraTutorial");
                break;
        case 5:
                SalirlEntrada.Play("EntraConfirmacion");
                break;
        }
    }

    public void SalidaMenus()
    {
        switch (AnimacionSwitch)
        {
            case 1:
                LogrosEntrada.Play("SalirLogros");
                break;
            case 2:
                CreditosEntrada.Play("SalirCreditos");
                break;
            case 3:
                RecordsEntrada.Play("SalirRecords");
                break;
            case 4:
                TutorialEntrada.Play("SalirTutorial");
                break;
            case 5:
                SalirlEntrada.Play("SaleConfirmacion");
                break;
        }
    }
    // Records corresponde a "mis datos"
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
    public void RecordsAnimacion()
    {
        SalidaMenus();
        AnimacionSwitch = 3;
        EntraMenus();
    }
    public void TutorialAnimacion()
    {
        SalidaMenus();
        AnimacionSwitch = 4;
        EntraMenus();
    }
    public void SalirAnimacion()
    {
        SalidaMenus();
        AnimacionSwitch = 5;
        EntraMenus();
    }
}
