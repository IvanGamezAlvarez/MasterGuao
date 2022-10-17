using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowFloor : MonoBehaviour
{
    public GameObject playerRef;
    public float slowSpeed;
        private void Start()
    {
        playerRef = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playerRef.GetComponent<PlayerScripts>().playerData.speed /= slowSpeed;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerRef.GetComponent<PlayerScripts>().playerData.speed *= slowSpeed;
        }
    }
}
