
using UnityEngine;
[System.Serializable]

public class Data
{
    public float record; 

    public Data(Client client)
    {
        record = client.record;
    }

}
