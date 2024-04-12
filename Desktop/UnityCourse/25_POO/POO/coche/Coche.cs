using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coche
{  //Propiedades de la clase 
    protected string _marca;
    protected Color _color;
    protected string _modelo;
    protected int _speed;
    protected int _hard;
    protected GameObject _car; 

    public Coche(string marca,Color color,string modelo,int speed,int hard,GameObject car) //constructor parametrizado
    {
        this._marca = marca; 
        this._color = color; 
        this._modelo = modelo;
        this._speed = speed;
        this._hard = hard; 
        this._car = car;
    }
    public Coche(string marca="Seat") //Constructor por defecto 
    {
        this._marca=marca;  
    }

    //metodos  

    public virtual void Run()
    {
        this._car.transform.position += new Vector3(0, 0, _speed * Time.deltaTime);
    }

    //Getters y Setters 

    //Getters
    public Color GetColor()
    {
        return _color;
    }
    public int GetSpeed()
    {
        return this._speed;
    }
    public int GetHard()
    {
        return this._hard;
    }
    public GameObject GetCar()
    {
        return this._car;
    }
    //Setters 
    public void SetColor(Color color)
    {
        this._color = color;
    }
    public void SetSpeed(int speed)
    {
        this._speed = speed;

    }
    public void SetHard(int hard)
    {
        this._hard = hard;
    }



}

  

