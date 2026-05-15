using System.Diagnostics.Contracts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

public class ControlUIGame : MonoBehaviour
{
    [Header("Energia")]
    public Sprite[] Energia;
    int indiceenergia;
    public Image imagenenergia;
    public int nivelEnergia;
    public Slider sliderEnergia;

    [Header("Vida")]
    public Animator vida;
    public int AnimacionSwitch;
    public int nivelVida;

    //Aqui está todo lo que manejará la vide y energia
    
    void Start()

    {
        AnimacionSwitch = PlayerPrefs.GetInt("Vida", 3);
        indiceenergia = PlayerPrefs.GetInt("Energia", 4);
        sliderEnergia.value = indiceenergia;

        AnimacionVidas();
        CambioEnergia();
    }
        
        public void CambioEnergia()
    {
        indiceenergia = Convert.ToInt32(sliderEnergia.value);
        imagenenergia.sprite = Energia[indiceenergia];
        PlayerPrefs.SetInt("Energia", indiceenergia);
        PlayerPrefs.Save();
        //Convierto el float del slider en int para poder usar su value
    }

    //Gestion de la vida
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
        PlayerPrefs.SetInt("Vida", AnimacionSwitch);
        PlayerPrefs.Save();
    }
    public void Vidamenos()
    {
        AnimacionSwitch--;
        if (AnimacionSwitch < 0) { AnimacionSwitch = 0; }
        AnimacionVidas();
        PlayerPrefs.SetInt("Vida", AnimacionSwitch);
        PlayerPrefs.Save();
    }
}