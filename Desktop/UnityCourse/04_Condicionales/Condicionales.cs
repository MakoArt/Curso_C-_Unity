using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionales : MonoBehaviour
{
    int number1 = 34;
    int number2 = 40;

    //Comparacion == !=  <  >  <=  >=           logicos   || && ! (or , and , not)

    private void Start()
    {
        //if(number1 != number2)
        // {
        //     Debug.Log("La condicion se ha cumplido"); 
        // }
        // else
        // {
        //     Debug.Log("La condicion no se ha cumplido");

        // }


        //switch (number1)
        //{
        //    case 0:
        //        Debug.Log("Correcto");
        //        break; 
        //    case 1:
        //        Debug.Log("Correcto");
        //        break;
        //    case 2:
        //        Debug.Log("Correcto");
        //        break;
        //    default:
        //        Debug.Log("Ninguna de las opciones es correcta");
        //        break;
        //}

        string resultado = ""; 

        resultado= number1 == 34 ? "Es verdad" : " Es mentira";

        Debug.Log(resultado);

    }


}
