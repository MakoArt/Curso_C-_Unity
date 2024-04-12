using UnityEngine;

[System.Serializable]

public class PlayerDatas 
{
    public int health;
    public int score; 
    public float[]position = new float[3];

    public PlayerDatas(Player1 player)
    {
        health = player.health;
        score = player.score;
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }



}
