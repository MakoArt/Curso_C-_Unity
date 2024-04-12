using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    [SerializeField] SpawnerData spawnerData;
    public Transform playerTransform;
    Canvas2 canvas2;
    [SerializeField]Client client;
    int index;


    private void Awake()
    {
        canvas2= GameObject.FindGameObjectWithTag("Canvas2").GetComponent<Canvas2>();
       

    }

    private void Start()
    {   
        StartCoroutine(GeneratePrefabsCoroutine());
      
        Instantiate(spawnerData.playerObject, playerTransform.position + new Vector3(0,1,0), Quaternion.identity);
    }

   

    IEnumerator GeneratePrefabsCoroutine()
    {
        int spawnerRandom = Random.Range(0, spawnerData.prefabTransform.Count);
        int prefabRandom = Random.Range(0, spawnerData.prefabList.Count); 

        yield return new WaitForSeconds(spawnerData.velocitySpawner);
         
     

        
            Instantiate(spawnerData.prefabList[prefabRandom],
                        spawnerData.prefabTransform[spawnerRandom].position,
                        spawnerData.prefabList[prefabRandom].transform.rotation);

        if (canvas2.timerMinutes < PlayerPrefs.GetInt("GameTime"))
        {
            StartCoroutine(GeneratePrefabsCoroutine()); 

        }
        else
        {
      
            float actualPercent = canvas2.percent;

            if (actualPercent >= client.GetRecord())
            {
                client.record = actualPercent;
                client.SaveData();
            }
            else
            {
                client.record = client.GetRecord();
            } 

            SceneManager.LoadScene(4);

       
         
        }


       




    }


 
}
