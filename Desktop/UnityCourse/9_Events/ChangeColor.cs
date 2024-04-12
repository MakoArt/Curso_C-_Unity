using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; //tenemos que usar el system para los eventos

public class ChangeColor : MonoBehaviour
{

    Player player;

    private void Awake()
    {
        Renderer renderer= GetComponent<Renderer>();    
        player=GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

    }

    private void playerChoque()
    {
        Debug.Log("Muerto");
    }
    private void tonto()
    {
        Debug.Log("Soy Tonto");
    }
    void Start()
    {
        player.choque += playerChoque;  //nos subscribimos al evento 
        player.choque += tonto;
    }

   

    private void OnDisable()
    {
        player.choque -= playerChoque;
    }
}
