using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControlUIGame : MonoBehaviour
{
    [Header("Energia")]
    public Sprite[] Energia;
    int indiceenergia;
    public Image imagenenergia;


    [Header("Vida")]
    public Animator vida;

    public int AnimacionSwitch;

    void Start()
    {
        indiceenergia = 0;
        imagenenergia.sprite = Energia[indiceenergia];
    }
        public void Energiamas()
     {
        indiceenergia++;
        if (indiceenergia > 4) { indiceenergia = 4; }
        imagenenergia.sprite = Energia[indiceenergia];
     }

      public void Energiamenos()
    {
        indiceenergia--;
        if (indiceenergia < 0) { indiceenergia = 0; }
        imagenenergia.sprite = Energia[indiceenergia];
    }

    public void AnimacionVidas()
    {
        switch (AnimacionSwitch)
        {
            case 1:
                vida.Play("Vida1");
                break;
            case 2:
                vida.Play("Vida2");
                break;
            case 3:
                vida.Play("Vida3");
                break;
        }
    }

    public void Vidaamas()
    {
        AnimacionSwitch ++;
        if (AnimacionSwitch > 3) { AnimacionSwitch = 3; }
        AnimacionVidas();

    }
    public void Vidamenos()
    {
        AnimacionSwitch--;
        if (AnimacionSwitch < 0) { AnimacionSwitch = 0; }
        AnimacionVidas();
    }

}