using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{
    [SerializeField] List<Renderer> rendererList; 

    public enum ColorState {WHITE,BLACK,RED,GREEN,BLUE}
    public ColorState colorState;

    void Start()
    {
        colorState=ColorState.WHITE; 
    }

     public  void ChangeColor( )
    {   
        Color newColor= new Color();

        if (colorState == ColorState.WHITE) newColor = Color.white;
        if (colorState == ColorState.BLACK) newColor = Color.black;
        if (colorState == ColorState.RED) newColor = Color.red;
        if (colorState == ColorState.GREEN) newColor = Color.green;
        if (colorState == ColorState.BLUE) newColor = Color.blue;

        foreach (Renderer renderer in rendererList)
        {
            renderer.material.color = newColor;
        }
        
       
        
    }

  

}
