using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class constructorEnemigos : MonoBehaviour
{
     public int playerId;
   
    
    public int vida;
    public int velocidad;
    private Transform posicionActual;
    private int daño;


    public ConstructorPlayer(int id, int vida, int vel){
        this.playerId=id;
        
        this.vida=vida;
        this.velocidad=vel;
    }

}