using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class GameD : MonoBehaviour
{
    public int Money = 0;
    public int Level = 0;



    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            Money += 1;
       
  
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Level += 1;
       
  
        }
        if (Input.GetKeyDown(KeyCode.G))
        {

            StartCoroutine(DataCoroutine());

        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            PlayerPrefs.SetInt ("Money",0);
            PlayerPrefs.SetInt("Level",0);
        }

       

    }

    private void PrintData()
    {
        Debug.Log(" Tenemos la cantidad de dinero de " + BD_PP.GetI("Money"));
        Debug.Log(" Estamos en el nivel " + BD_PP.GetI("Level"));
    }

    IEnumerator DataCoroutine()
    {
        yield return new WaitForSeconds(1);
        
          BD_PP.SaveI("Money", Money);
          BD_PP.SaveI("Level", Level);

         yield return new WaitForSeconds(1);
             PrintData();

        StopCoroutine(DataCoroutine());
        
    }

}
