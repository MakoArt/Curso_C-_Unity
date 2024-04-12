using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Ibarco;


interface Iavion
{
    float GetHight();
    void SetHight(float hight);

}
interface ICoche
{
    float stability { get { return stability; } }
    float GetStability();
    void SetStability(float stability);

}
interface Ibarco
{
    enum GetMotor { VELA, MOTOR, ZODIAC };
    public GetMotor GetMotorFunction();
    public void SetMotorFunction(GetMotor getMotor);

}
interface Imoto
{
    enum TypeMoto { RACES, CROSS, CHOPPER, CITY }
    public TypeMoto GetTypeMotoFunction();
    public void SetTypeMotoFunction(GetMotor getMotor);

}