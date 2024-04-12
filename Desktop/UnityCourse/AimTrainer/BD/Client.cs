using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public float record;
    public int money;


    private void Start()
    {
        Data data = MiddleWare.LoadData();
        if (data == null)
        {
            Debug.Log("No hay datos Guardados podemos tener un error"); 
            SaveData();
        }
        else
        {
            Debug.Log("Hay Datos y no vamos a tener errores");
        }
    }


    public void SaveData()
    {
        MiddleWare.SaveData(this);
        Debug.Log("Datos Guardados");
    }
    
    public float GetRecord()
    {
        Data data = MiddleWare.LoadData(); 
        record= data.record;    
        return record;
    }

  


}
