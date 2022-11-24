using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fregadero : MonoBehaviour
{
    public GameObject Espuma;
    public Vector3 mousePos;
    private Vector3 objPos;
    public int contador;


    //public GameObject esponja;
    public bool agarrar;
    // Start is called before the first frame update
    void Start()
    {
        agarrar = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (contador >= 1000)
        {
            Debug.Log("Ganaste");
        }


        if (agarrar == true)
        {
            //Para que la esponja siga al cursor, el valor de 7.0f puede variar
            mousePos = Input.mousePosition;
            mousePos.z = 7.0f;
            objPos = Camera.main.ScreenToWorldPoint(mousePos);
            this.transform.position = objPos;
            contador++;
            
             
        }
    }





}
