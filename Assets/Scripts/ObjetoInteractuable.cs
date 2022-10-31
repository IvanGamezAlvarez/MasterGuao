using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjetoInteractuable : MonoBehaviour
{
    public GameObject playerReference;
    public bool presionando;
    
    public void Awake()
    {
        playerReference = GameObject.Find("Player");
    }
    private void Update()
    {
      
    }
    public void ActivarVentana(GameObject ventana2D)
    {
        
        if (Input.GetKey(KeyCode.E))
        {
            ventana2D.SetActive(true);
            playerReference.GetComponent<PlayerScripts>().onHud = true;
            
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
    public void _Inputs()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            presionando = true;
            Debug.Log("presionando");
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            presionando = false;
            Debug.Log("despresionando");
        }
    }
    public void Cleaning(GameObject[] objectsToClean)
    {
        foreach (GameObject item in objectsToClean)
        {
            item.tag = "Untagged";
            item.GetComponent<MeshRenderer>().material.color = Color.white;
            item.SetActive(false);
        }
    }


}
