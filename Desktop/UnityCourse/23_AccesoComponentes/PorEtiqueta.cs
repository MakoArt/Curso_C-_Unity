using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorEtiqueta : MonoBehaviour
{
    GameObject player;
    Renderer playerRenderer;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerRenderer = GameObject.FindGameObjectWithTag("Player").GetComponent<Renderer>();

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
