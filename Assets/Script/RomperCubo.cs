using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RomperCubo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col){
        Debug.Log( gameObject.name + " Colisiono con" + col.gameObject.name);
       
       if(col.gameObject.name == "CuboPlayer"){
        Destroy(col.gameObject);
        }
        else if(col.gameObject.name == "piso"){
            //reposition
        }
    }
}
