using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Progreso : MonoBehaviour
{

    public Transform target;
    public float speed;
    public bool Boost1;
    public bool Boost2;
    public Transform Object1;
    public GameObject victory;
   
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.W))
        {
            Boost1 = true;
            Object1.transform.localPosition = new Vector3(-4.23f, -1.82f, -1.67f);
           
        }
     
        if (Input.GetKeyDown(KeyCode.S))
        {
            Boost1 = true;
            Object1.transform.localPosition = new Vector3(-4.23f, -6.1f, -1.67f);
        }
      

        if (Boost1 == true)
        {
           transform.localPosition += new Vector3(speed, 0, 0);
            Boost1 = false;
        }
      

    }
    
}
