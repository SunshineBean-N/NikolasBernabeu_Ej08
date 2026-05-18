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

    [Header("Contador")]
    public int tiempoInicial = 30;
    public TMP_Text letritasContador;

    [Header("Inventario")]
    public Animator InventarioEntrada;


    void Start()

    {
        AnimacionSwitch = PlayerPrefs.GetInt("Vida", 3);
        indiceenergia = PlayerPrefs.GetInt("Energia", 4);
        sliderEnergia.value = indiceenergia;

        AnimacionVidas();
        CambioEnergia();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            InventarioAnimacion();
        }
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

    // CRONOMETRO
    public void BotonContador()
    {
        StartCoroutine(ContadorRegresivo(tiempoInicial));
    }
    IEnumerator ContadorRegresivo(int segundos)
    {
        int tiempoRestante = segundos;

        while (tiempoRestante > 0)
        {
            letritasContador.text = tiempoRestante.ToString();
            yield return new WaitForSeconds(1);
            tiempoRestante--;

            if (tiempoRestante <= 10)
            {
                letritasContador.color = Color.red;

                //sonidoTermina.play();
                Debug.Log("TERMINA");

            }
        }
    }

    public void SalidaInventario()
    {
        switch (AnimacionSwitch)
        {
            case 1:
                InventarioEntrada.Play("InventarioSale");
                break;
        }
    }
    public void EntraInventario()
    {
        switch (AnimacionSwitch)
        {
            case 1:
                InventarioEntrada.Play("InventarioEntra");
                break;
        }
    }

    public void InventarioAnimacion()
    {
        SalidaInventario();
        AnimacionSwitch = 1;
        EntraInventario();
    }

}