using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Pasivos : ObjetoInteractuable
{
    public ScriptableElements cocinaScriptable;
    public GameObject contenido;
    public TextMeshProUGUI textoDeAviso;
    public GameObject ventanDeAviso;
    public bool SeEntrego, Inside;
    public float timer;
    public MeshRenderer colorDelAlimento;
    public float tiempoDeCocinado, tiempoDeQuemado;
    public bool seCocino, seQuemo;
    public string tagToInsert;
 
    private void Update()
    {
        if(SeEntrego)
        {
            timer += Time.deltaTime;
            Cocinando();
        }
        else
        {
            RestaurarParametros();
        }
        _Inputs();
        
    }
    private void OnTriggerStay(Collider other)
    {
        //se entrego
        if (cocinaScriptable.vegetalesAceptados == playerReference.transform.Find(cocinaScriptable.vegetalesAceptados).gameObject.name && playerReference.transform.Find(cocinaScriptable.vegetalesAceptados).gameObject.activeSelf == true && presionando && playerReference.transform.Find(cocinaScriptable.vegetalesAceptados).gameObject.tag == "Untagged")
        {
            playerReference.transform.Find(cocinaScriptable.vegetalesAceptados).gameObject.SetActive(false);
            contenido.SetActive(true);
            SeEntrego = true;
            Debug.Log("semetio");
            presionando = false;
        }
        //no tienes el objeto
        else
        {

            if (presionando && SeEntrego == false )
            {
                textoDeAviso.text = "No puedes acceder te hace falta: " + cocinaScriptable.vegetalesAceptados + ".";
                ventanDeAviso.SetActive(true);
                timer = 0;

            }
        }
        // recoger
        if (SeEntrego && presionando  )
        {

            playerReference.transform.Find(cocinaScriptable.vegetalesAceptados).gameObject.SetActive(true);
            contenido.SetActive(false);
            if (seCocino)
            {
                playerReference.transform.Find(cocinaScriptable.vegetalesAceptados).gameObject.tag = tagToInsert;
                colorDelAlimento.material.color = Color.white;
            }
            if (seQuemo)
            {
                playerReference.transform.Find(cocinaScriptable.vegetalesAceptados).gameObject.tag = "Burn";
                colorDelAlimento.material.color = Color.white;
            }
            else
            {
                timer = 0;

            }
            Debug.Log("Se saco");
            SeEntrego = false;
            presionando = false;
            //  SeEntrego = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        ventanDeAviso.SetActive(false);
    }
    public void Cocinando()
    {
        MeshRenderer colorDeObjetoPlayer = playerReference.transform.Find(cocinaScriptable.vegetalesAceptados).gameObject.GetComponent<MeshRenderer>();
        
        if (timer > tiempoDeCocinado && timer < tiempoDeQuemado)
        {
           // Debug.Log("Se Cocino");
            colorDelAlimento.material.color = Color.red;
            colorDeObjetoPlayer.material.color = Color.red;
            seCocino = true; 


        }
        if (timer > tiempoDeQuemado)
        {
            
         //       Debug.Log("Se Quemo");
                colorDelAlimento.material.color = Color.black;
                colorDeObjetoPlayer.material.color = Color.black;
                seQuemo = true;
            seCocino = false;



        }
    }
    public void RestaurarParametros()
    {
        timer = 0;
    }

}
