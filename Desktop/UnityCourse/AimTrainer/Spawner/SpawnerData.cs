using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnerData", menuName = "Spawner")]
public class SpawnerData : ScriptableObject
{
    public List<GameObject> prefabList;
    public List<Transform> prefabTransform;
   
    public GameObject playerObject;

    public int velocitySpawner;
    public int time;

}
