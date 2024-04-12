using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EnemyBody"))
        {
            Destroy(other.gameObject); 
            Destroy(this.gameObject);
        }
    }
}
