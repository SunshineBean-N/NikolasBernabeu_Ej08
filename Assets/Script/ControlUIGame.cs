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
        imagenenergia.sprite = Energia[indiceenergia];
    
     }
      public void Energiamenos()
    {
        indiceenergia--;
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
        AnimacionVidas();

    }
    public void Vidamenos()
    {
        AnimacionSwitch--;
        AnimacionVidas();
    }

}