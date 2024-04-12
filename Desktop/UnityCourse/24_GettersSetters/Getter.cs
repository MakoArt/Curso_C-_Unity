using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Getter : MonoBehaviour
{
    GettersSetters gettersSetters;

    private void Awake()
    {
        gettersSetters = GameManager.FindObjectOfType<GettersSetters>();
    }
    void Start()
    {
        Debug.Log(gettersSetters.Lifes);
        gettersSetters.Lifes = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
