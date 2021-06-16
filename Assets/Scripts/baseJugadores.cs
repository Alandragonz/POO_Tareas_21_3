using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseJugadores : MonoBehaviour
{
    public constructorPlayer[] nuevoJugador;
    
    // Start is called before the first frame update
    void Awake()
    {
       nuevoJugador= new constructorPlayer[1];
       nuevoJugador[0] = new constructorPlayer(1,"Wolf",3,5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
