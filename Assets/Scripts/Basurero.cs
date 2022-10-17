using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basurero : MonoBehaviour
{
    public GameObject[] objectsToClean;
    public Transform playerRef;
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            if(Input.GetKey(KeyCode.E))
            {
                Debug.Log("hi");
                foreach (GameObject item in objectsToClean)
                {
                    item.tag = "Untagged";
                    item.GetComponent<MeshRenderer>().material.color = Color.white;
                    item.SetActive(false);
                }
               
            }
        }


    }
}
