using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyColliders : MonoBehaviour
{
    [SerializeField] NavMeshIA navMeshIA;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            navMeshIA.agent.SetDestination(navMeshIA.player.transform.position);
        }
  
    }
    private void OnTriggerExit(Collider other)
    {
        navMeshIA.agent.SetDestination(navMeshIA.player.transform.position);
    }
}
