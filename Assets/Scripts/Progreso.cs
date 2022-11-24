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
        float step = speed/10 * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        if (Input.GetKeyDown(KeyCode.W))
        {
            Boost1 = true;
            Object1.position= new Vector3 (-0.2f, 1.77f, -1.67f);
           
        }
        else
        {
            Boost1 = false;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Boost2 = true;
            Object1.position = new Vector3(-0.2f, -0.16f, -1.67f);
        }
        else
        {
            Boost2 = false;
        }
        if (Boost1 == true)
        {
            speed++;
        }
        if (Boost2 == true)
        {
            speed++;
        }

    }
    
}
