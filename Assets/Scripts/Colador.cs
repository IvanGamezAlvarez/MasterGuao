using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Colador : MonoBehaviour
{
    public Image ModeloHorizontal;

    public float tiempo = 5;
    private float ContadorTiempo;
    public Text horizontal;

    // Start is called before the first frame update
    void Start()
    {
        ContadorTiempo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (ContadorTiempo <= tiempo)
        {
            ContadorTiempo = ContadorTiempo + Time.deltaTime;
            ModeloHorizontal.fillAmount = ContadorTiempo / tiempo;
            horizontal.text = (Convert.ToInt32(100 * ModeloHorizontal.fillAmount)).ToString() + "%";
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            ContadorTiempo = ContadorTiempo + 1 + Time.deltaTime;
            ModeloHorizontal.fillAmount = ContadorTiempo / tiempo;
            horizontal.text = (Convert.ToInt32(100 * ModeloHorizontal.fillAmount)).ToString() + "%";
            
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            ContadorTiempo = ContadorTiempo + 1 + Time.deltaTime;
            ModeloHorizontal.fillAmount = ContadorTiempo / tiempo;
            horizontal.text = (Convert.ToInt32(100 * ModeloHorizontal.fillAmount)).ToString() + "%";
           
        }

    }
}
