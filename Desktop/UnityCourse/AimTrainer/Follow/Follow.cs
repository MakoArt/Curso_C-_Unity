using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] FollowData followData;

    Transform player;
    Transform Enemy;



    private void Awake()
    {
       
    
    }
    private void FollowFunction()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        transform.LookAt(player.position);
        transform.Translate(0, 0, followData.speed * Time.deltaTime);
    

        
    }

    private void AttackFunction()
    {
        Debug.Log("Estoy atacando");

    }

    private void StopFunction()
    {

        Debug.Log("Paro");
      
    }


    private void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        Enemy = GameObject.FindGameObjectWithTag("Empties").GetComponent<Transform>();
        float dist = Vector3.Distance(player.position, transform.position);
        float distEnemy = Vector3.Distance(Enemy.position, transform.position);
        if (dist > 3) FollowFunction();
        if (dist <= 3) AttackFunction();
        if (distEnemy <= 3) StopFunction();
        if (distEnemy > 3) FollowFunction();
        if (distEnemy <= 3 && dist <= 3) AttackFunction();
    }

}
