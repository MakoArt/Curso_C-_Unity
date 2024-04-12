using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genericos2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Genericos<string> gene=new Genericos<string>();

        Debug.Log(gene.WeaponFunction("hola","hola","hola"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
