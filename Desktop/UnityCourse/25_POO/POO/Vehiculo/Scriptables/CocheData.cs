using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CocheData", menuName = "Coche")]
public class CocheData : ScriptableObject
{
    [SerializeField] public GameObject carObject;
    public string marca;
    public float stability;
    public int price;
    public Color color;

}
