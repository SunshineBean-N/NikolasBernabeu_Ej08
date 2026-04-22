using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class JestorMenu : MonoBehaviour
{
    public Animator LogrosEntrada;
    public Animator CreditosEntrada;
    public Animator RecordsEntrada;
    public Animator TutorialEntrada;
    public Animator SalirlEntrada;

    public int AnimacionSwitch;
    //Apunta al "numero" de el menu

    [Header("principales")]
    public TextMeshProUGUI botonNombreText;
    public TextMeshProUGUI botonJuegoText;
    public TextMeshProUGUI botonOpcionesText;
    public TextMeshProUGUI botonSalirText;

    [Header("Secundarios")]
    public TextMeshProUGUI botonSeguroText;
    public TextMeshProUGUI botonSiText;
    public TextMeshProUGUI botonNoText;

    public TextMeshProUGUI botonCreditosText;

    public TextMeshProUGUI botonLogrosText;

    public TextMeshProUGUI botonDatosText;
    public TextMeshProUGUI botonNombreDatosText;
    public TextMeshProUGUI botonApellidoDatosText;
    public TextMeshProUGUI botonCorreoDatosText;
    public TextMeshProUGUI botonEdadDatosText;


    private string[,] matrizIdiomas = new string[3, 14]
    {
        { "Introduce tu nombre", "Jugar", "Opciones", "Salir", "¿Seguro?", "Sí", "No", "Créditos", "Logros", "Tus datos", "Nombre", "Apellido", "Correo", "Edad" },
        { "Introduce o teu nome", "Xogar", "Opcións", "Saír", "Seguro?", "Si", "Non", "Créditos", "Logros", "Os teus datos", "Nome", "Apelidos", "Correo electrónico", "Idade" },
        { "Enter your nametag", "Play", "Options", "Exit", "Sure?", "Yes", "No", "Credits", "Achievements", "Your details", "First name", "Last name", "Email", "Age" },
    };
    //cambiar todo esto para opciones
    //crear matriz por escena
    int i;
    void Start()
    {
        i = PlayerPrefs.GetInt("Idioma", 0);
        ActualizarTextos();  }
    //Llamo a i con playerprefs para cambiar su estado, por defecto está en 0 y si cambia varia

    public void ActualizarTextos()
    {
        botonJuegoText.text = matrizIdiomas[i, 0];
        botonJuegoText.text = matrizIdiomas[i, 1];
        botonOpcionesText.text = matrizIdiomas[i, 2];
        botonSalirText.text = matrizIdiomas[i, 3];
    }

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
