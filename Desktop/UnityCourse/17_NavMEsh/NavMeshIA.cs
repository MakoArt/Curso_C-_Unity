using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshIA : MonoBehaviour
{
    [SerializeField] Transform routeEnemy;
    [SerializeField] List<Transform> points;
    public NavMeshAgent agent;
    public GameObject player;
    private int indexPoints = 0;

    void Start()
    {
        BagPoint();
        NextPoint();
    }
    private void BagPoint()
    {
        for(int i = 0; i < routeEnemy.childCount; i++)
        {
            points.Add((Transform)routeEnemy.GetChild(i));

        }
    }
    private void NextPoint()
    {
        if (points.Count == 0)
        {
            return;
        }
        else if (indexPoints == points.Count - 1)
        {
            indexPoints = 0;
        }
        else
        {
            indexPoints++;
        }
        agent.SetDestination(points[indexPoints].position);
    }


    void Update()
    {
        if(agent.remainingDistance < 1 && !agent.pathPending)
        {
            NextPoint();
        }
    }
}
