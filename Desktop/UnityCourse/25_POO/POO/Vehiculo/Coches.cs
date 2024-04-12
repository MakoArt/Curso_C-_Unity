using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coches : Vehiculo,ICoche
{
    public Coches() : base() { }


    float _stability;
    public float Stability { get { return this._stability; } set { this._stability = value; } }

    public float GetStability()
    {
        return this._stability;
    }

    public void SetStability(float stability)
    {
        this._stability = stability;
    }
}
