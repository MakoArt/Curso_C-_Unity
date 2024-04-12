using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveDataPlayer 
{
    public static void SavePlayerData(Player1 player)
    {
        PlayerDatas playerDatas = new PlayerDatas(player);
        string dataPath = Application.persistentDataPath + "/player.save";
        FileStream fileStream = new FileStream(dataPath,FileMode.Create); 
        BinaryFormatter binaryFormatter= new BinaryFormatter(); 
        binaryFormatter.Serialize(fileStream, playerDatas);
        fileStream.Close();
    }

    public static PlayerDatas LoadPlayerData()
    {
        string dataPath = Application.persistentDataPath + "/player.save"; 
        if(File.Exists(dataPath))
        {
            FileStream fileStream = new FileStream(dataPath,FileMode.Open); 
            BinaryFormatter binaryFormatter= new BinaryFormatter();  
            PlayerDatas playerDatas=(PlayerDatas)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            return playerDatas;
        }
        else
        {
            Debug.Log("No se encontró el archivo de guardado");
            return null;
        }
    }
}
