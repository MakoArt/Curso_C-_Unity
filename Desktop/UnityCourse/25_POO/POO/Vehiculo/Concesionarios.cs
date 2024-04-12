using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Concesionarios : MonoBehaviour
{
    public List<CocheData> cocheData;
    List<Coches> clases = new List<Coches>();


    private void Start()
    {
        AgregarCoches(); 
        GetDataCar();
    }
    public void AgregarCoches()
    {


        for (int i = 0; i < cocheData.Count; i++)
        {
            Coches coche = new Coches();
            coche.SetMarca(cocheData[i].marca);
            coche.SetPrice(cocheData[i].price);
            coche.SetColor(cocheData[i].color);
            coche.SetStability(cocheData[i].stability);
             clases.Add(coche);
        }

       
    }

    public void GetDataCar()
    {
        for (int i = 0; i < clases.Count; i++)
        {
            Debug.Log(" Marca : " + clases[i].GetMarca() + "--" + " precio : " + clases[i].GetPrice());
        }

    }
}


 