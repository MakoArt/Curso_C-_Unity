using Math;
using UnityEngine;

public class MyFirstScript:MonoBehaviour
{ 
    Math.MathLib mathLib;


    private void Awake()
    {
     mathLib = new MathLib();
    }

    private void Start()
    {
       // Debug.Log("Hola Mundo");
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
          
            //Debug.Log(mathLib.Add(2, 4));
        }
    }
}
