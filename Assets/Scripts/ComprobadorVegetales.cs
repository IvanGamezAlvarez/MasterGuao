using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ComprobadorVegetales : ObjetoInteractuable
{
    public ScriptableElements cocinaScriptable;
    public GameObject ventanaDeMinijuego;
    public TextMeshProUGUI textoDeAviso;
    public GameObject ventanDeAviso;
    private void OnTriggerStay(Collider other)
    {
        
        Debug.Log(playerReference.transform.Find(cocinaScriptable.vegetalesAceptados).gameObject.name);
        if (cocinaScriptable.vegetalesAceptados == playerReference.transform.Find(cocinaScriptable.vegetalesAceptados).gameObject.name && playerReference.transform.Find(cocinaScriptable.vegetalesAceptados).gameObject.activeSelf == true)
        {
            Debug.Log("U did it");
           ActivarVentana(ventanaDeMinijuego);
        }
        else
        {
           
            if (Input.GetKey(KeyCode.E))
            {
                textoDeAviso.text = "No puedes acceder te hace falta: " + cocinaScriptable.vegetalesAceptados + ".";
                Debug.Log("WE TRIED");
                ventanDeAviso.SetActive(true);
               

            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        ventanDeAviso.SetActive(false);
    }
}
