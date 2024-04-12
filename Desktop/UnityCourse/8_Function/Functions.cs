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
    // la modificacion seguirá incluso fuera de la funcion  

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
Seguridad: Al pasar por valor, se crea una copia local de la variable. Esto significa que los cambios dentro de la función no afectarán la variable original fuera de ella.
Predecible: El comportamiento es más predecible, ya que no hay sorpresas en cuanto a modificaciones inesperadas.
Desventajas:
Overhead: Se crea una copia de la variable, lo que puede ser costoso en términos de memoria y rendimiento.
Ineficiente para objetos grandes: Si la variable es un objeto grande, copiarlo puede ser ineficiente.



Paso por referencia:
Ventajas:
Eficiencia: No se crea una copia; la función trabaja directamente con la variable original.
Modificaciones reflejadas: Los cambios dentro de la función afectan directamente a la variable original.
Desventajas:
Menos seguro: Puede ser más difícil rastrear y predecir cambios en la variable original.
Efectos secundarios inesperados: Si no se maneja correctamente, las modificaciones pueden afectar otras partes del código.
En resumen:

Paso por valor es más seguro y predecible, pero puede ser costoso en términos de rendimiento.
Paso por referencia es más eficiente, pero requiere precaución para evitar efectos secundarios inesperados.
La elección depende de tus necesidades específicas y del lenguaje de programación que estés utilizando. Por ejemplo:
     
     
     
     
     
     
     
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
    //        Debug.Log("VALOR DENTRO DE LA FUNCIÓN : " + numero);
    //    }

    //    private void Start()
    //    {
    //        int numeroOriginal = 5;
    //        Suma(numeroOriginal);
    //        Debug.Log("VALOR FUERA DE LA FUNCIÓN : " + numeroOriginal);

    //    }



    //}







}
