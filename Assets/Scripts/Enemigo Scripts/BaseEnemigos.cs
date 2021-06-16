using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemigos : MonoBehaviour
{
     public ConstructorEnemigos[] nuevoEnemigo;
    
    // Start is called before the first frame update
    void Awake()
    {
       nuevoEnemigo= new ConstructorEnemigos[4];
       nuevoEnemigo[0] = new ConstructorEnemigos(1,2,5);
       nuevoEnemigo[0] = new ConstructorEnemigos(1,1,5);
  
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
