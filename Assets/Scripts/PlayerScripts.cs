using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour
{
    #region variables
    [System.Serializable]
    public struct PlayerData
    {

        public float speed, speedRotation;

        public bool isPlaying2D;
    }
    [Header("Reeferencias")]
    public Rigidbody rb;
    public PlayerData playerData;
    [Header("Efectos y Eventos")]
    public float time;
    public float calor;
    public GameObject Suciedad;
    #endregion

    #region Event Function
    private void Awake()
    {
    }
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
    #endregion

    #region Player Function
    void PlayerController()
    {
        if (playerData.isPlaying2D == false)
        {
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            float verticalInput = Input.GetAxisRaw("Vertical");
            Vector3 movementDirection = new Vector3(horizontalInput, rb.velocity.y, verticalInput);
            // movementDirection.Normalize();
            rb.velocity = movementDirection * playerData.speed * Time.deltaTime;
            if (movementDirection != Vector3.zero)
            {
                Quaternion toRotarion = Quaternion.LookRotation(movementDirection, Vector3.up);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotarion, playerData.speedRotation * Time.deltaTime);
            }
        }
    }
   
    public void Tropezar(GameObject suciedad)
        {
           Instantiate(suciedad, gameObject.transform.position, Quaternion.identity);
        }
    public  void SinTiempo(float tiempo)
        {

        }

    #endregion
}