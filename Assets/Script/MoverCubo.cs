using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCubo : MonoBehaviour

{
    public float der = 1f;
    public float izq = -1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D)){
            transform.Translate(der, 0, 0);
        }

        else if(Input.GetKeyDown(KeyCode.A)){
             transform.Translate(izq, 0, 0);
        }
    }
}

