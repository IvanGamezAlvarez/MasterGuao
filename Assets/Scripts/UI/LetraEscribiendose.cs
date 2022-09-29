using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class LetraEscribiendose : MonoBehaviour
{
    
    public string fraseAMostrar;
    public TextMeshProUGUI texto;
    public float tiempoDeInvocacion;

    // Start is called before the first frame update
    void Start()
    {
        texto = GetComponent<TextMeshProUGUI>();
        StartCoroutine(Reloj());
        Time.timeScale = 1;
    }

    IEnumerator Reloj()
    {
        foreach (char caracter in fraseAMostrar)
        {
            texto.text = texto.text + caracter;
            yield return new WaitForSeconds(tiempoDeInvocacion);
        }
    }
}