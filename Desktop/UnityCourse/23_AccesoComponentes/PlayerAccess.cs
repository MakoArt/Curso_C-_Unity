using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAccess : MonoBehaviour
{
    Renderer playerRenderer;

    private void Awake()
    {
        playerRenderer = GetComponent<Renderer>();
    }

    void Start()
    {
        transform.localScale = new Vector3(1, 3, 1);
        playerRenderer.material.color = Color.blue;
    }

   
    void Update()
    {
        
    }
}
