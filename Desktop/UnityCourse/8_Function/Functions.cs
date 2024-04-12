using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Functions : MonoBehaviour
{
    [SerializeField] Renderer cube;

    int num1=12;
    int num2=12;

    //LAMBDA  

    string GetMessage(string frase) => frase; //retornamos directamente


    //VALOR VS REFERENCIA 

    //parametros por valor   // por referencia  ref , out , in 

    //ref 
    //cuando pasamos por argumentos a los parametors ref , vamos 
    // a modificar la referencia la real  , no una copia de la variable con lo cual 
    // la modificacion seguir� incluso fuera de la funcion  

    //out  
    //cuando inicamos una variable dentro de una funcion aunque 
    //esta fuera declarada pero no inicializada usaremos out , luego fuera 
    // la variable seguira teniendo el valor que inicio dentro de la funcion  

    //in 
    //cuando no queremos que el valor se pueda modificar dentro del metodo
    //pasamos a la funcion el in por parametros pero como intentemos modificarla 
    //dentor nos dara un error es como un readonly  

    //Los objetos por defecto se quedan modificados una vez se pasan al metodo 
    // aunque no especifiquemos nada con la parabra ref 

    //PARAMETROS OPCIONALES  
    //en los parametros le damos el valor y ya no nos obliga a ponerlo en argumentos 

    //MEMORIA STACK Y HEAP  
    //STACK MEMORIA ordenada , estricta , lifo , stackoverflow exception 
    //HEAP DESORDENADA , LIBRE , DINAMICA , no reglas para eliminar o agregar , outofmemory exception 

    /*
     
     Paso por valor:
Ventajas:
Seguridad: Al pasar por valor, se crea una copia local de la variable. Esto significa que los cambios dentro de la funci�n no afectar�n la variable original fuera de ella.
Predecible: El comportamiento es m�s predecible, ya que no hay sorpresas en cuanto a modificaciones inesperadas.
Desventajas:
Overhead: Se crea una copia de la variable, lo que puede ser costoso en t�rminos de memoria y rendimiento.
Ineficiente para objetos grandes: Si la variable es un objeto grande, copiarlo puede ser ineficiente.



Paso por referencia:
Ventajas:
Eficiencia: No se crea una copia; la funci�n trabaja directamente con la variable original.
Modificaciones reflejadas: Los cambios dentro de la funci�n afectan directamente a la variable original.
Desventajas:
Menos seguro: Puede ser m�s dif�cil rastrear y predecir cambios en la variable original.
Efectos secundarios inesperados: Si no se maneja correctamente, las modificaciones pueden afectar otras partes del c�digo.
En resumen:

Paso por valor es m�s seguro y predecible, pero puede ser costoso en t�rminos de rendimiento.
Paso por referencia es m�s eficiente, pero requiere precauci�n para evitar efectos secundarios inesperados.
La elecci�n depende de tus necesidades espec�ficas y del lenguaje de programaci�n que est�s utilizando. Por ejemplo:
     
     
     
     
     
     
     
     */

    public void sumar( int  numero1,  int numero2)
    {
        numero1 +=10;
        numero2 += 10;
        Debug.Log("Los resultados son " + numero1 + " " + numero2);
    }


    private void Start()
    {
        ChangeColor(new Color32(34,230,35,1));
        sumar( num1 ,  num2 );
       
    }
    private void Update()
    {
        Debug.Log(num1 + " " + num2);
    }
    //FUNCIONES NORMALES 
    private void ChangeColor(Color32 col)
    {
 
        cube.material.color = col;    
    }
    //FUNCIONES CON RETORNO  


    //faciles 


    //public class Referencias : MonoBehaviour
    //{



    //    public void Suma(int numero)
    //    {
    //        numero = numero * 2;
    //        Debug.Log("VALOR DENTRO DE LA FUNCI�N : " + numero);
    //    }

    //    private void Start()
    //    {
    //        int numeroOriginal = 5;
    //        Suma(numeroOriginal);
    //        Debug.Log("VALOR FUERA DE LA FUNCI�N : " + numeroOriginal);

    //    }



    //}







}
