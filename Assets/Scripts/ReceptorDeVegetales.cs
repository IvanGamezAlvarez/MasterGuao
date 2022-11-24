using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceptorDeVegetales : ObjetoInteractuable
{
    public string[] VegetalesParaElPlatillo;
    public GameObject[] alimentoALimpiar;
    public int cuentaDeVegetales;
    [Header ("Pondremos El Mismo Numero De bools que de Vegetales en el Platillo")]
    public bool[] comprobadorDeVegetales;
    public int puntos;
    public GameObject VentanaVictoria;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _Inputs();
        Ganar();
    }
    public void VegetalesAceptados()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        
        if(presionando)
        {
          
            for (int i = 0; i < VegetalesParaElPlatillo.Length; i++)
            {
                if (VegetalesParaElPlatillo[i] == other.transform.Find(VegetalesParaElPlatillo[i]).gameObject.name && other.transform.Find(VegetalesParaElPlatillo[i]).gameObject.activeSelf == true && other.transform.Find(VegetalesParaElPlatillo[i]).gameObject.tag == "Goal")
                {
                    Debug.Log($"tienes {VegetalesParaElPlatillo[i]}");
                    comprobadorDeVegetales[i] = true;
                    puntos++;
                    other.transform.Find(VegetalesParaElPlatillo[i]).gameObject.SetActive(false);
                    Cleaning(alimentoALimpiar);

                }
            }
        }
    }
    void Ganar()
    {
        if  ( puntos == comprobadorDeVegetales.Length)
        {
            VentanaVictoria.SetActive(true);
        }
    }
}
