using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Equipment : ScriptableObject
{
    public new string name;

    //set
    public string experience;

    public string GetEquipmentType()
    {
        return this.GetType().ToString();
    }
}