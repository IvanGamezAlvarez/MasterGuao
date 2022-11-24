using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaJuego : MonoBehaviour
{
    public float timeOfMatch;
    public Image ImagenDeTiempo;
    public bool gameStarted;
    public GameObject ventanaPerdiste;
    void Awake()
    {
        ImagenDeTiempo = GetComponent<Image>();
    }


    void Update()
    {
        if(gameStarted)
        {
            TimeOfGame();

        }
    }
    void TimeOfGame()
    {
        
        ImagenDeTiempo.fillAmount -= 1.0f/timeOfMatch * Time.deltaTime; 
        if (ImagenDeTiempo.fillAmount <= 0)
        {
            ventanaPerdiste.SetActive(true);
        }

    }
    public void StartGame()
    {
        gameStarted = true;
    }
}
