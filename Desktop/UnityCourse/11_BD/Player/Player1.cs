using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player1 : MonoBehaviour
{
    public int health = 5;
    public int score=0;
    [SerializeField] TMP_Text healthT;
    [SerializeField] TMP_Text scoreT;




    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score += 1;
            Debug.Log(score);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            health -= 1;
            Debug.Log(health);
        }  
        if (Input.GetKeyDown(KeyCode.G))
        {
            SaveDataPlayer.SavePlayerData(this);
            Debug.Log("Datos Guardados");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            PlayerDatas playerDatas=SaveDataPlayer.LoadPlayerData();
            score= playerDatas.score;
            health= playerDatas.health;
            transform.position = new Vector3(playerDatas.position[0], playerDatas.position[1], playerDatas.position[2]);
            Debug.Log("Datos Cargados");
            healthT.text=health.ToString();
            scoreT.text=score.ToString();
        }
    }


}
