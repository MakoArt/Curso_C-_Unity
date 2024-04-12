using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Punch : MonoBehaviour
{
    [SerializeField] PlayerLifes playerLifes;
    
  
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Player")
        {

            playerLifes.UpdateLifesPlayer();
        }
    }
}
