using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closet : ObjetoInteractuable
{

    public GameObject objetoAAgarrar;

  
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            AgarrarObjeto(objetoAAgarrar);
        }
    }
}
