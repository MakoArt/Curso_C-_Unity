using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;


//Aviones  Barcos  Coches  motos
public class Vehiculo
{
    protected int price;
    protected Color color;
    protected float speed;
    protected string marca;
    protected GameObject objectCar;


    public Vehiculo(int price,Color color,float speed,string marca,GameObject objectCar) 
    { 
      this.price = price; 
      this.color = color;    
      this.speed = speed; 
      this.marca = marca;
      this.objectCar = objectCar;
    }
    protected Vehiculo() { }

    public string GetMarca()
    {
        return this.marca;
    }
    public void SetMarca(string marca)
    {
        this.marca = marca;
    }
    public int GetPrice()
    {
        return this.price;
    }
    public int SetPrice(int price)
    {
        return this.price = price;
    }

    public Color GetColor()
    {
        return this.color;
    }
    public void SetColor(Color color)
    {
        this.color = color;
    }

    public float GetSpeed()
    {
        return this.speed;
    }
    public void SetSpeed(float speed)
    {
        this.speed = speed;

    }
    public GameObject GetObject()
    {
        return this.objectCar;
    }
    public void SetObject(GameObject objectCar)
    {
        this.objectCar=objectCar;   
    }


}
