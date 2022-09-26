using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjetoInteractuable : MonoBehaviour
{
   
   public void ActivarVentana(GameObject ventana2D)
    {
        
        if (Input.GetKey(KeyCode.E))
        {
            ventana2D.SetActive(true);
            
        }
    }
    public void DesactivarVentana(GameObject ventana2D)
    {

        if (Input.GetKey(KeyCode.F))
        {
            ventana2D.SetActive(false);
        }
    }
    public void AgarrarObjeto(GameObject Objeto)
    {

        if (Input.GetKey(KeyCode.E))
        {
           Objeto.SetActive(true);

        }
    }



}
