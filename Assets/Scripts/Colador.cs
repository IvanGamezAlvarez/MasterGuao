using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colador : MonoBehaviour
{
    public Transform target;
    public float speed;
    public bool Boost1;
    public bool Boost2;
    public Transform Object1;
   

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed / 10 * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        if (Input.GetKeyDown(KeyCode.A))
        {
            Boost1 = true;
        }
        else
        {
            Boost1 = false;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Boost2 = true;
        }
        else
        {
            Boost2 = false;
        }
        if (Boost1 ==true)
        {
            speed++;
            
        }
        if(Boost2==true)
        {
            speed++;
        }
    }

}
