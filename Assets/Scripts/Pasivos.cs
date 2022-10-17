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
    private void Update()
    {
        if(SeEntrego)
        {
            timer += Time.deltaTime;
            Cocinando();
        }
    }
    private void OnTriggerStay(Collider other)
    {

        if (cocinaScriptable.vegetalesAceptados == playerReference.transform.Find(cocinaScriptable.vegetalesAceptados).gameObject.name && playerReference.transform.Find(cocinaScriptable.vegetalesAceptados).gameObject.activeSelf == true && Input.GetKey(KeyCode.E) && playerReference.transform.Find(cocinaScriptable.vegetalesAceptados).gameObject.tag == "Untagged")
        {
            Debug.Log("U did it");
            playerReference.transform.Find(cocinaScriptable.vegetalesAceptados).gameObject.SetActive(false);
            contenido.SetActive(true);
            SeEntrego = true;

           
        }
        else
        {

            if (Input.GetKey(KeyCode.E) && SeEntrego == false )
            {
                textoDeAviso.text = "No puedes acceder te hace falta: " + cocinaScriptable.vegetalesAceptados + ".";
                ventanDeAviso.SetActive(true);
                timer = 0;

            }
        }
        if (SeEntrego && Input.GetKey(KeyCode.E) && timer > 1 )
        {

            playerReference.transform.Find(cocinaScriptable.vegetalesAceptados).gameObject.SetActive(true);
            contenido.SetActive(false);
            if (seCocino)
            {
                playerReference.transform.Find(cocinaScriptable.vegetalesAceptados).gameObject.tag = "Cooked";
                colorDelAlimento.material.color = Color.white;
            }
            if (seQuemo)
            {
                playerReference.transform.Find(cocinaScriptable.vegetalesAceptados).gameObject.tag = "Burn";
                colorDelAlimento.material.color = Color.white;
            }
          //  SeEntrego = false;
            timer = 0;
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
            Debug.Log("Se Cocino");
            colorDelAlimento.material.color = Color.red;
            colorDeObjetoPlayer.material.color = Color.red;
            seCocino = true; 


        }
        if (timer > tiempoDeQuemado)
        {
            
                Debug.Log("Se Quemo");
                colorDelAlimento.material.color = Color.black;
                colorDeObjetoPlayer.material.color = Color.black;
                seQuemo = true;
            seCocino = false;



        }
    }
}
