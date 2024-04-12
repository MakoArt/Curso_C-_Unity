//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class IA : MonoBehaviour
{
    GameObject[] routePoints1;
    GameObject[] routePoints2;
    [SerializeField] GameObject player;
    [SerializeField] float speed = 0.01f;
    [SerializeField] float distanceToChangeDirection = 1f;
    [SerializeField] float rotSpeed = 0.5f;
    [SerializeField] GameObject enemy1;
    [SerializeField] GameObject enemy2;
    [SerializeField] List<GameObject> enemiesList;
    [SerializeField] Animator animator;

    float random1;
    float random2;

    int currentPoint = 0;
    int currentPoint2 = 0;
    float range = 500f;

    [SerializeField]  public  enum EnemyStates { PATRULLAR ,ATACAR}
    [SerializeField]  public EnemyStates enemyStates;



    private void Start()
    {
        routePoints1 = GameObject.FindGameObjectsWithTag("Points");
        routePoints2 = GameObject.FindGameObjectsWithTag("Point");

        random1 = Random.Range(1f, 2);
        random2 = Random.Range(1f, 2);
    }

    private void AtacarFunction()
    {   
        for(int i = 0;i<enemiesList.Count;i++) 
        {
            Vector3 lookAtGoal = new Vector3(player.transform.position.x, enemiesList[i].transform.position.y, player.transform.position.z);
            Vector3 direction = lookAtGoal - enemiesList[i].transform.position;
            enemiesList[i].transform.rotation = Quaternion.Slerp(enemiesList[i].transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);
            enemiesList[0].transform.Translate(0, 0, random1 * Time.deltaTime);
            enemiesList[1].transform.Translate(0, 0, random2 * Time.deltaTime);


            float dist = Vector3.Distance(player.transform.position, enemiesList[i].transform.position);
            if (dist <= 2)
            {
                Debug.Log("ESTOY ATACANDO");
                enemiesList[i].GetComponent<Renderer>().material.color = Color.red;
            }
            if (dist > 2)
            {
                Debug.Log("NO ESTOY ATACANDO");
                enemiesList[i].GetComponent<Renderer>().material.color = new Color32(255, 112, 40, 1);
            }
        }
       
        

    }

    private void PatrullarFunction()
    {
        if (routePoints1.Length == 0) return;

        Vector3 lookGoal = new Vector3(routePoints1[currentPoint].transform.position.x, routePoints1[currentPoint].transform.position.y, routePoints1[currentPoint].transform.position.z);
        Vector3 lookGoal2 = new Vector3(routePoints2[currentPoint2].transform.position.x, routePoints2[currentPoint2].transform.position.y, routePoints2[currentPoint2].transform.position.z);
        
        Vector3 direction1 = lookGoal - enemy1.transform.position; 
        Vector3 direction2 = lookGoal2 - enemy2.transform.position;
        
        enemy1.transform.rotation = Quaternion.Slerp(enemy1.transform.rotation, Quaternion.LookRotation(direction1), Time.deltaTime * rotSpeed);
        enemy2.transform.rotation = Quaternion.Slerp(enemy2.transform.rotation, Quaternion.LookRotation(direction2), Time.deltaTime * rotSpeed);

        //Movimiento del enemigo 1 

        if(direction1.magnitude < distanceToChangeDirection)
        {
            currentPoint++;
            
            if(currentPoint >= routePoints1.Length)
            {
                currentPoint = 0;
            }
        }
        enemy1.transform.Translate(0, 0, speed * Time.deltaTime);


        //Movimiento del enemigo2

        if (direction2.magnitude < distanceToChangeDirection)
        {
            currentPoint2++;

            if (currentPoint2 >= routePoints2.Length)
            {
                currentPoint2 = 0;
            }
        }
        enemy2.transform.Translate(0, 0, speed * Time.deltaTime);
    }



    private void EnemyStateFunction()
    {
        switch (enemyStates)
        {
            case EnemyStates.PATRULLAR:
                PatrullarFunction();
                break; 
            case EnemyStates.ATACAR:
                AtacarFunction();
                break;
         
            default:
                PatrullarFunction();
                break;
        }
    }



    private void Update()
    {
        EnemyStateFunction();
    }


}
