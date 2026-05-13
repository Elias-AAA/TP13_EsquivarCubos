using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RomperCubo : MonoBehaviour
{
    public float mid = 0.31f;
     public float der = 1.71f;
      public float izq = -1.09f;
       public float speed = 5; 
       // Start is called before the first frame update
         void Start()
          {

           }
            // Update is called once per frame
         void Update()
          { transform.Translate(0,-speed * Time.deltaTime,0);
           } void OnCollisionEnter(Collision col)
           { Debug.Log( gameObject.name + " Colisiono con" + col.gameObject.name);
            if(col.gameObject.name == "CuboPlayer"){ Destroy(col.gameObject);
             } else if(col.gameObject.name == "Piso")
             { speed += 0.5f; int random = Random.Range(0, 3); if(random == 0)
              { transform.position = new Vector3(izq, 10, 3.38f); } else if(random == 1)
               { transform.position = new Vector3(mid, 10, 3.38f);
                } else { transform.position = new Vector3(der, 10, 3.38f); } } }
}
