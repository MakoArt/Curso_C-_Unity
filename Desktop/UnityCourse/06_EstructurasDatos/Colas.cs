using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Colas : MonoBehaviour
{
    //FIFO 


    Queue<int> numeros = new Queue<int>();

    //rellenando o agregando elementos a la cola 

    private void Start()
    {
        
            numeros.Enqueue(6);
            numeros.Enqueue(76);
            numeros.Dequeue();

        Debug.Log(numeros.Count);

         
        foreach (int numero in numeros)
        {
            Debug.Log(numero);
        }
        
    }

}
