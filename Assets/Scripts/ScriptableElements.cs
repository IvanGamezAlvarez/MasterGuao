using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "VariablesParaCocina", menuName ="VariablesParaLosElementosDeCocina")]
public class ScriptableElements : ScriptableObject
{
    public bool tieneElVegetalCorrecta;
    public string[] vegetalesAceptados;
}
