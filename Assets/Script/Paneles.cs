using UnityEngine;

public class Paneles : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    public void TogglePanel() {  panel.SetActive(!panel.activeSelf); }

    public void OpenPanel() { panel.SetActive(true); }
    public void ClosePanel() { panel.SetActive(false); }
}
