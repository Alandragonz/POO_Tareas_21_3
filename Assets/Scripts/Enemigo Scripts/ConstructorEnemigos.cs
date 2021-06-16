using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class ConstructorEnemigos : MonoBehaviour
{
     // Atributos o propiedades
    public int EnemigoId;
    
    
    public int vida;
    public float velocidad;
    private Transform posicionActual;
    private int daño;
    
    //Metodo constructor
    public ConstructorEnemigos(int id, int vida, float vel){
        this.EnemigoId=id;
        
        this.vida=vida;
        this.velocidad=vel;

    }
}
