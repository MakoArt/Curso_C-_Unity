using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="VariablesData",menuName ="Variables")]
public class Variables : ScriptableObject
{
    public int lifes;
    public int money;
    public List<string> weapons;
    public bool isWarriorMode;


}
