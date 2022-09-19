using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorPlayer : ObjetoInteractuable
{
    public Outline outlineRef;
    public GameObject Instrucciones, ventana2D;
    
    private void Awake()
    {
        ventana2D = GameObject.FindGameObjectWithTag("2DView");
    }
    private void Start()
    {
        ventana2D.SetActive(false);
        outlineRef = GetComponent<Outline>();
        outlineRef.enabled = false;
        Instrucciones.SetActive(false);
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            Debug.Log("Holas");
            outlineRef.enabled = true;
            Instrucciones.SetActive(true);
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Holas");
            outlineRef.enabled = false;
            Instrucciones.SetActive(false);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ActivarVentana(ventana2D);
            DesactivarVentana(ventana2D);
           
        }
    }
}
