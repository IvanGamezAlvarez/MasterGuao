using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SALIDA : MonoBehaviour
{
    public GameObject victory;
    public GameObject target;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider Ventana2D)
    {
        if (target.CompareTag("Goal"))
        {
            Active();
        }
    }
    void Active()
    {
        victory.SetActive(true);
    }

    public void DesactivarVentansa(GameObject ventana2D)
    {

        if (Input.GetKey(KeyCode.F))
        {
            ventana2D.SetActive(false);
        }
    }
}
