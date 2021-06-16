using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseJugadores : MonoBehaviour
{
     public ConstructorJugador[] nuevoJugador;
    
    // Start is called before the first frame update
    void Awake()
    {
       nuevoJugador= new ConstructorJugador[4];
       nuevoJugador[0] = new ConstructorJugador(1,"Wolf",3,5);
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
