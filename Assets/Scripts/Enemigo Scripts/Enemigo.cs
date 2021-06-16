using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
     public int EnemigoId;
 
   public float vida;
   public float velocidad;

    BaseEnemigos bdEnemigos;
private void Start()
{
    bdEnemigos=GameObject.FindObjectOfType<BaseEnemigos>();
    CargarDatos(EnemigoId);
   
}
void CargarDatos(int id){
for (int i = 0; i < bdEnemigos.nuevoEnemigo.Length; i++)
{
    if (bdEnemigos.nuevoEnemigo[i].EnemigoId == id)
    {
    
    this.vida= bdEnemigos.nuevoEnemigo[i].vida;
    this.velocidad= bdEnemigos.nuevoEnemigo[i].velocidad; 
    }
    
}
}
    // Start is called before the first frame update
   
}
