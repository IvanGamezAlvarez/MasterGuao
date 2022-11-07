using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;




public class Mezcla : MonoBehaviour
{
    public Image ModeloHorizontal;

    public float tiempo = 5;
    private float ContadorTiempo;
    public Text horizontal;
    public bool boton1;
    public bool boton2;
    public bool boton3;
    public bool boton4;
    private bool[] secuencia;

    public float randomNum;



    // Start is called before the first frame update
    void Start()
    {
        
        ContadorTiempo = 0;
        boton1 = false;
        boton2 = false;
        boton3 = false;
        boton4 = false;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.W))
        {
            boton1 = true;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            boton2 = true;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            boton3 = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            boton4 = true;
        }

        if (ContadorTiempo <= tiempo)
        {
            ContadorTiempo = ContadorTiempo + Time.deltaTime;
            ModeloHorizontal.fillAmount = ContadorTiempo / tiempo;
            horizontal.text = (Convert.ToInt32(100 * ModeloHorizontal.fillAmount)).ToString() + "%";
        }
        if (boton1 & boton2 & boton3 & boton4 == true)
        {
            ContadorTiempo = ContadorTiempo + 2 + Time.deltaTime;
            ModeloHorizontal.fillAmount = ContadorTiempo / tiempo;
            horizontal.text = (Convert.ToInt32(100 * ModeloHorizontal.fillAmount)).ToString() + "%";
           
            StartCoroutine(Crono());
        }
        IEnumerator Crono()
        {
            yield return new WaitForSeconds(.02f);
            boton1 = false;
            boton2 = false;
            boton3 = false;
            boton4 = false;
        }
        for (int i =0; i<4;i++)
        {
          
        }
    }
}

