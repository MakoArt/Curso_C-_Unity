using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName ="EnemyData",menuName ="Enemy")]
public class EnemyData : ScriptableObject
{


    public float speedPatrol = 2f;
    public float speedAttack = 0f;
    public float speedFollow = 4f;
    public float distanceToChangeDirection = 1f;
    public float rotSpeed = 2f;
    public float attackDistance = 1.5f;
    public int currentPoint = 0;
    public Slider sliderLife;
  

    
}
