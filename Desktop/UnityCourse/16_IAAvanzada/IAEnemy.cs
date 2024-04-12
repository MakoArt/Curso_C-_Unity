using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IAEnemy : MonoBehaviour
{
    [SerializeField] EnemyData enemyData;
    Transform player;
    Animator animator;
    GameObject[] routePoints;
    [SerializeField] GameObject punch;

    public enum EnemyStates { PATROL, FOLLOW  , HIT , DEATH }
    public EnemyStates enemyStates;

    


    private void Awake()
    {    animator = GetComponent<Animator>();
         routePoints = GameObject.FindGameObjectsWithTag("Points");
         enemyData.sliderLife = GameObject.FindGameObjectWithTag("SliderMonster").GetComponent<Slider>();
  
    }


    private void FollowFunction()
    {
       

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        Vector3 lookAtGoal = new Vector3(player.position.x, transform.position.y, player.position.z);
        Vector3 direction = lookAtGoal - transform.position;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * enemyData.rotSpeed);


        float dist = Vector3.Distance(player.position, transform.position);

        if (dist <= enemyData.attackDistance)
        {
            punch.GetComponent<Collider>().enabled = true;
            animator.SetBool("Hit", false);
            animator.SetBool("Run", false);
            animator.SetBool("Attack", true);
            GetComponent<Renderer>().material.color = Color.red;
            transform.Translate(0, 0, enemyData.speedAttack * Time.deltaTime);
        }
        if (dist > enemyData.attackDistance)
        {
            punch.GetComponent<Collider>().enabled = false;
            animator.SetBool("Hit", false);
            animator.SetBool("Run", true);
            animator.SetBool("Attack", false);
            GetComponent<Renderer>().material.color = new Color32(255, 112, 40, 1);
            transform.Translate(0, 0, enemyData.speedFollow * Time.deltaTime);
        }

    } 


    private void PatrolFunction()
    {
       // animator.SetBool("Walk", true);
        animator.SetBool("Run", false);
        animator.SetBool("Attack", false);

        if (routePoints.Length == 0) return;

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    
        Vector3 lookGoal = new Vector3(routePoints[enemyData.currentPoint].transform.position.x, transform.position.y, routePoints[enemyData.currentPoint].transform.position.z);
        Vector3 direction = lookGoal - transform.position;


        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * enemyData.rotSpeed);


        //Movimiento del enemigo 

        if (direction.magnitude < enemyData.distanceToChangeDirection)
        {
            enemyData.currentPoint++;

            if (enemyData.currentPoint >= routePoints.Length)
            {
                enemyData.currentPoint = 0;
            }
        }
        transform.Translate(0, 0, enemyData.speedPatrol * Time.deltaTime);

        GetComponent<Renderer>().material.color = Color.green;

    }

    private void HitFunction()
    {
        transform.Translate(0, 0,  0 );
        animator.SetBool("Hit", true);

    }
    private void DeathFunction()
    {
        transform.Translate(0, 0, 0);
        animator.SetBool("Death", true);
        StartCoroutine(DeathCoroutine());
    }


    private void EnemyStateFunction()
    {
        switch (enemyStates)
        {
            case EnemyStates.PATROL:
                PatrolFunction();
                break;
            case EnemyStates.FOLLOW:
                FollowFunction();
                break;
            case EnemyStates.HIT:
                HitFunction();
                break;
            case EnemyStates.DEATH:
                DeathFunction();
                break;

            default:
                PatrolFunction();
                break;
        }
    }





    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            enemyStates = EnemyStates.FOLLOW;
            GetComponent<Renderer>().material.color = new Color32(255, 112, 40, 1);

        }


    }


    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Player"))
        {


            enemyStates = EnemyStates.PATROL;
            GetComponent<Renderer>().material.color = Color.green;

        }
    }


    private void Update()
    {
        EnemyStateFunction();
    }

    IEnumerator DeathCoroutine()
    {
        yield return new WaitForSeconds(10);
        Destroy(this.gameObject);
        StopCoroutine(DeathCoroutine());
    }
   


}
