using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PlayerScripts : MonoBehaviour
{
    
    [System.Serializable]
    public struct PlayerData
    {

        public float speed, speedRotation;

        public bool isPlaying2D;
    }
    [Header("Reeferencias")]
    public Rigidbody rb;
    public PlayerData playerData;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Debug.Log(playerData.isPlaying2D);
    }
    void FixedUpdate()
    {
        PlayerController();
    }
    void PlayerController()
    {
        if (playerData.isPlaying2D == false)
        {
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            float verticalInput = Input.GetAxisRaw("Vertical");
            Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
            // movementDirection.Normalize();
            rb.velocity = movementDirection * playerData.speed * Time.deltaTime;
            if (movementDirection != Vector3.zero)
            {
                Quaternion toRotarion = Quaternion.LookRotation(movementDirection, Vector3.up);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotarion, playerData.speedRotation * Time.deltaTime);
            }
        }
      
    }
}
