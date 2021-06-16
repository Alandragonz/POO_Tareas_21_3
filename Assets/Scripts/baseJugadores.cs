using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseJugadores : MonoBehaviour
{
    public ConstructorPlayer[] nuevoJugador;
    
    // Start is called before the first frame update
    void Awake()
    {
       nuevoJugador= new ConstructorPlayer[1];
       nuevoJugador[0] = new ConstructorPlayer(1,"Wolf",3,5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
