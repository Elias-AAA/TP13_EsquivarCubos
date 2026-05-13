using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using UnityEngine;

public class Tiempo : MonoBehaviour
{
    public TextMeshProUGUI Puntaje;
    
    float tiempo = 0;

    void Update()
    {
        tiempo += Time.deltaTime;

        texto.text = tiempo.ToString("F2");
    }
}