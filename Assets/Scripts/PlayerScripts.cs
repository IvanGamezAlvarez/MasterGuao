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
    public bool onHud;
    [Header("UI and Animations")]
    public GameObject PauseMenu;
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
        PausasYSalirDelMenu();
    }
    void FixedUpdate()
    {
        if(!onHud)
        {
            PlayerController();
        }
    
    }
    #endregion

    #region Player Function
    void PlayerController()
    {
        if (playerData.isPlaying2D == false)
        {
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            float verticalInput = Input.GetAxisRaw("Vertical");
            Vector3 movementDirection = new Vector3(horizontalInput * playerData.speed * Time.deltaTime, rb.velocity.y, verticalInput * playerData.speed * Time.deltaTime);
            // movementDirection.Normalize();
            rb.velocity = movementDirection;
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
    public void DesableHud()
    {
        onHud = false;
       
    }
    public void PausasYSalirDelMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
          
            
        }
    }


    #endregion
}