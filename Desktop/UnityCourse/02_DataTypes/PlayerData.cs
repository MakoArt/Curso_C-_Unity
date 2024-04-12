using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public string playerName = "Jhon";
    public string playerSurname = "McGregor";
    public sbyte money = 127;//CURIOSIDAD //su valor tiene que ser de 127 o menos
    public short moneyInBank = 456;//CURIOSIDAD entre -32767 y 32767
    public long price = 2343242;//CURIOSIDAD ENTRE -9.223.327.036.854.775.807 y 9.223.327.036.854.775.807
    public int age = 34; //CURIOSIDAD -2.147.483.647 hasta 2.147.483.647
    public float numberHair = 3445; // CURIOSIDAD entre 1.5*10^-45   3.4*10^38 precision de 7 digitos
    public double numeroDouble = 34.34324324;//precisión de 15 digitos.
    public decimal numeroDecimal = 4.545m;//CURIOSIDAD Precision de 28 digitos.
    public char character = '#';
    public bool isHetero = true;
    public bool isGay = false;
    public bool isBinary = false;
    public bool isSimp = true;
    public bool heFeelsLikeWoman=true;

    //CONSTANTES 

    public const int COLA_PRICE = 1;
    



    void Start()
    {
        //CONCATENACIÓN  DE VARIABLES 

        Debug.Log("El campeón de la noche es : " + playerName + " " + playerSurname);
        Debug.Log($"El campeón de la noche es {playerName} {playerSurname}");
      
    
    }


    void Update()
    {
        
    }
}
