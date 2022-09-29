using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorPlayer : ObjetoInteractuable
{
    public Outline outlineRef;
    public GameObject ventana2D;

    [Header ("si no vas a activar nada, desactiven")]
    public bool ActivarasVentana;

    private void Start()
    {
        outlineRef = GetComponent<Outline>();
        outlineRef.enabled = false;
       
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            outlineRef.enabled = true;
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            outlineRef.enabled = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (ActivarasVentana)
        {
            if (other.CompareTag("Player"))
            {
                ActivarVentana(ventana2D);


            }
        }
       
    }
}
