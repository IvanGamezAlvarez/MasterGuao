using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOnAndOff : MonoBehaviour
{
    public GameObject[] toDecactivated;
    public GameObject toActivated;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            toActivated.SetActive(true);
            foreach (GameObject item in toDecactivated)
            {
                item.SetActive(false);
            }
        }
      
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            toActivated.SetActive(false);
            foreach (GameObject item in toDecactivated)
            {
                item.SetActive(true);
            }
        }
    }
}
