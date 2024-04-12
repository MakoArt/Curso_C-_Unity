using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BD_PP : MonoBehaviour
{    
    public static BD_PP instance;
    //GUARDAR Y CARGAR ENTEROS 
    public static void SaveI(string nameData,int intData)
    {
        int db = PlayerPrefs.GetInt(nameData);
        PlayerPrefs.SetInt(nameData,intData + db);
    }
    public static int GetI(string nameData)
    {
        return PlayerPrefs.GetInt(nameData);    
    }
    //GUARDAR Y CARGAR FLOTANTES
    public static void SaveF(string nameData, float floatData)
    {
        float db = PlayerPrefs.GetFloat(nameData);
        PlayerPrefs.SetFloat(nameData, floatData + db);
    }
    public static float GetF(string nameData)
    {
        
            return PlayerPrefs.GetFloat(nameData);
       
    }
    //GUARDAR Y CARGAR STRING
    public static void SaveS(string nameData, string stringData)
    {
       
        PlayerPrefs.SetString(nameData, stringData);
    }
    public static string GetS(string nameData)
    {
        
            return PlayerPrefs.GetString(nameData);
       
     }
}
