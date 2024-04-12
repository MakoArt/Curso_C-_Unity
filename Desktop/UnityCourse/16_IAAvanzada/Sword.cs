using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{


    EnemiesLifes enemiesLifes;

    private void Awake()
    {
        enemiesLifes = GameObject.FindGameObjectWithTag("EnemiesLifes").GetComponent<EnemiesLifes>();
    }

    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.name == "Enemy1")
        {

            enemiesLifes.UpdateLifesMonster();

        }
    }

    
  
}
