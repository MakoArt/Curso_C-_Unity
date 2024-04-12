using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilas : MonoBehaviour
{
    //LIFO  

    Stack<int> numeros = new Stack<int>();

    private void Start()
    {

        numeros.Push(6);
        numeros.Push(76);
        numeros.Push(34);

        numeros.Pop();

        Debug.Log(numeros.Count);


        foreach (int numero in numeros)
        {
            Debug.Log(numero);
        }
    }


}
