using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Castint : MonoBehaviour
{
    double doubleVariable = 34.3434;
    int intVariable;

   

 

    void Start()
    {
        //conversion explicita perdemos datos decimales (casting)
        //intVariable = (int)doubleVariable;
        //Debug.Log(intVariable.GetType());

        //conversion implicita  de menos a mas datos (casting)
        //int numero = 345234;
        //long num = numero;
        //Debug.Log(num.GetType());



        // pasamos un dato a otro  

        string cadena = "345";
        string cadena2 = "445"; 
        
        string resultado=cadena+cadena2; 

        int parseoaEntero=Int32.Parse(cadena);

        Debug.Log(parseoaEntero.GetType());


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
