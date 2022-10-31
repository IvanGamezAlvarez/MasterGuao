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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _Inputs();
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
                if (VegetalesParaElPlatillo[i] == other.transform.Find(VegetalesParaElPlatillo[i]).gameObject.name && other.transform.Find(VegetalesParaElPlatillo[i]).gameObject.activeSelf == true && other.transform.Find(VegetalesParaElPlatillo[i]).gameObject.tag == "Cooked")
                {
                    Debug.Log($"tienes {VegetalesParaElPlatillo[i]}");
                    comprobadorDeVegetales[i] = true;
                    other.transform.Find(VegetalesParaElPlatillo[i]).gameObject.SetActive(false);
                    Cleaning(alimentoALimpiar);

                }
            }
        }
    }
}
