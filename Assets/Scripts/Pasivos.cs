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
    public bool SeEntrego;
    public float timer;
    public MeshRenderer colorDelAlimento;
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

        Debug.Log(playerReference.transform.Find(cocinaScriptable.vegetalesAceptados).gameObject.name);
        if (cocinaScriptable.vegetalesAceptados == playerReference.transform.Find(cocinaScriptable.vegetalesAceptados).gameObject.name && playerReference.transform.Find(cocinaScriptable.vegetalesAceptados).gameObject.activeSelf == true && Input.GetKey(KeyCode.E))
        {
            Debug.Log("U did it");
            playerReference.transform.Find(cocinaScriptable.vegetalesAceptados).gameObject.SetActive(false);
            contenido.SetActive(true);
            SeEntrego = true;
           
        }
        else
        {

            if (Input.GetKey(KeyCode.E) && SeEntrego == false)
            {
                textoDeAviso.text = "No puedes acceder te hace falta: " + cocinaScriptable.vegetalesAceptados + ".";
                Debug.Log("WE TRIED");
                ventanDeAviso.SetActive(true);


            }
        }
        if (SeEntrego && Input.GetKey(KeyCode.E) && timer > 1 )
        {

            playerReference.transform.Find(cocinaScriptable.vegetalesAceptados).gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        ventanDeAviso.SetActive(false);
    }
    public void Cocinando()
    {
        MeshRenderer colorDeObjetoPlayer = playerReference.transform.Find(cocinaScriptable.vegetalesAceptados).gameObject.GetComponent<MeshRenderer>();

        if (timer > 3)
        {
            Debug.Log("red");
            colorDelAlimento.material.color = Color.red;
            colorDeObjetoPlayer.material.color = Color.red;
        }
    }
}
