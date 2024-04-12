using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Statics : MonoBehaviour
{
    public static Statics Instance;
    public bool isDestroy;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
           if(!isDestroy) DontDestroyOnLoad(Statics.Instance);
           if(isDestroy) Destroy(Statics.Instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
