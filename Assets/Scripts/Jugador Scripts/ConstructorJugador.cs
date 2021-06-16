using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 [System.Serializable]
public class ConstructorJugador
{
     // Atributos o propiedades
    public int playerId;
    public string nombre;
    
    public int vida;
    public float velocidad;
    private Transform posicionActual;
    private int daño;
    
    //Metodo constructor
    public ConstructorJugador(int id, string n, int vida, float vel){
        this.playerId=id;
        this.nombre=n;
        this.vida=vida;
        this.velocidad=vel;

    }
}
