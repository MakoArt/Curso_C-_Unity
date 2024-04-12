using System; //poner la directiva esta
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class Errores : MonoBehaviour
{
    int number1 = 234;
    int number2 = 345;

    void Start()
    {
        try
        {
            if (number1 == number2)
            {
                Debug.Log("El number1 es igual a number2");
            }
            else
            {
                Debug.Log("El number2 no es igual");
            }
        }
        catch (Exception)
        {
            Debug.Log(" Algo no anda bien ");
        }
        finally
        {
            Debug.Log(" Me sigo ejecutando independientemente ");
        }
    }

    

    // Update is called once per frame
    void Update()
    {

    }
}
