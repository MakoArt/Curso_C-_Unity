
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


public class MiddleWare : MonoBehaviour
{

    public static void SaveData(Client client)
    {
        Data data = new Data(client);
        string dataPath = Application.persistentDataPath + "/data.save";
        FileStream fileStream = new FileStream(dataPath, FileMode.Create);
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        binaryFormatter.Serialize(fileStream, data);
        fileStream.Close();
    }  



    public static Data LoadData()
    {
        string dataPath = Application.persistentDataPath + "/data.save";
        if (File.Exists(dataPath))
        {
            FileStream fileStream = new FileStream(dataPath, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Data data = (Data)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            return data;
        }
        else
        {
            Debug.Log("Archivo no existente");
            return null;
        }
    }
}
