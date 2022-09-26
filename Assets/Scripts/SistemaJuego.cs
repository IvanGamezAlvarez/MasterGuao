using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaJuego : MonoBehaviour
{
    public float timeOfMatch;
    public Image ImagenDeTiempo;
    void Awake()
    {
        ImagenDeTiempo = GetComponent<Image>();
    }


    void Update()
    {
        TimeOfGame();
    }
    void TimeOfGame()
    {
        
        ImagenDeTiempo.fillAmount -= 1.0f/timeOfMatch * Time.deltaTime; 

    }
}
