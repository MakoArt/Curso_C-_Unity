using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operaciones : MonoBehaviour
{
    public int number1; 
    public int number2;
 
    void Start()
    {
        number1 = 3;
        number2 = 4;
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)) Debug.Log($"El resultado de la suma es {number1 + number2}");
        if(Input.GetKeyDown(KeyCode.R)) Debug.Log($"El resultado de la resta es {number1 - number2}");
        if(Input.GetKeyDown(KeyCode.M)) Debug.Log($"El resultado de la división es {number1 * number2}");
        if(Input.GetKeyDown(KeyCode.D)) Debug.Log($"El resultado de la división es {number1 / number2}");
        if(Input.GetKeyDown(KeyCode.E)) Debug.Log($"El resultado de la división es modulo {number1 % number2}");
    
    
    }

    //problema 
    //Un padre y una hija vuelven de andorra , son detenidos en la frontera 
    //y obligados a pagar el 50% de sus ganancias como streamers en andorra 
    // si el padre ha ganado 2000000 de euros y la hija 2000000 de euros 
    // y el novio de la hija ha ganado 1000000 

    //ORDEN DE OPERACIONES   
    //-------------------------------
    //POTENCIAS Y RAICES 
    //MULTIPLICACIONES Y DIVISIONES 
    //SUMAS Y RESTAS 
}
