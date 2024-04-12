using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Concesionario : MonoBehaviour
{
    [SerializeField] List<GameObject> cars;
    [SerializeField] GameObject invisibleCar;
    GameObject isCar; 

    public enum StateCar { SEAT,RENAULT}
    public StateCar stateCar;


    public void IsCarInScene()
    {
        isCar = GameObject.FindGameObjectWithTag("Car").gameObject;
        if (isCar) Destroy(isCar);
    }


    public void GenerateCar(int index)
    {
        if (index == 1)
        {
            Coche seat = new Coche("seat", Color.black, "Ibiza", 160, 4, cars[0]);
            GameObject newSeat = Instantiate(seat.GetCar());
            if (newSeat) newSeat.GetComponent<Renderer>().material.color = seat.GetColor();
        }

        if (index == 2)
        {
            Coche renault = new Coche("renault", Color.blue, "Twingo", 120, 2, cars[1]);
            GameObject newRenault = Instantiate(renault.GetCar());
            if (newRenault) newRenault.GetComponent<Renderer>().material.color = renault.GetColor();
        }


    }


    IEnumerator GenerateCoroutineCar(StateCar stateCar)
    {
        IsCarInScene();
        yield return new WaitForSeconds(1);
        if (stateCar == StateCar.SEAT) GenerateCar(1);
        if (stateCar == StateCar.RENAULT) GenerateCar(2);

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            if (stateCar == StateCar.SEAT) StartCoroutine(GenerateCoroutineCar(stateCar = StateCar.SEAT));
            if (stateCar == StateCar.RENAULT) StartCoroutine(GenerateCoroutineCar(stateCar = StateCar.RENAULT));
        }
    }











}
