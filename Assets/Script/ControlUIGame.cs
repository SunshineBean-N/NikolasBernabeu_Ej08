using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControlUIGame : MonoBehaviour
{
    public Animator[] vida;
    int indiceVida;
    public Image imagenVida;
    void Start()
    {
        indiceVida = 0;
    }
    public void Vidamas()
    {
        indiceVida++;
        imagenVida.sprite = vida[indiceVida];

    }
    public void Vidamenos()
    {
        indiceVida--;
        imagenVida.sprite = vida[indiceVida];
    }
}