using UnityEngine;

public class Paneles : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    //SerialozeField permite aparecer en el inpector el recuadro para arrastrar

    public void TogglePanel() { panel.SetActive(!panel.activeSelf); }
    //Se crea el public void TogglePanel y se le dice si esta activo y se invierte lo mismo para decirle lo contrario

    public void OpenPanel() { panel.SetActive(true); }
    public void ClosePanel() { panel.SetActive(false); }

    //Necesito un Open y un Close para indicar a los distintos paneles si estan en true o false, para que se pueda indicar si se desactiva o activa
}
