using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScriptsNavegation : MonoBehaviour
{
   
   
    public void Pausar()
    {
        Time.timeScale = 0;
    }
    public void Continuar()
    {
        Time.timeScale = 1;
    }
    public void Salir(int sceneMenu)
    {
        SceneManager.LoadScene(sceneMenu);
    }
    public void Reiniciar(int sceneThisLevel)
    {
        SceneManager.LoadScene(sceneThisLevel);
    }

}
