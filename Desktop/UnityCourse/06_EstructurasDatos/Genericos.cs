using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class Genericos<T>  //clases preparadas para colecciones genericas 
{
    public T nombre;
    public T edad;



    
    public List<T> WeaponFunction(T dato1,T dato2,T dato3)
    {   
        List<T> list = new List<T>(); 
        list.Add(dato1);    
        list.Add(dato2);    
        list.Add(dato3);    
        foreach(T t in list)
        {
            Debug.Log(t);
        }
        return new List<T>();
    }


}


