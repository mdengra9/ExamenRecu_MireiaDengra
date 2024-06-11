using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableItems : ScriptableObjects
{
    public class enum itemType
    {
        ArmaUno,
        ArmaDos
    }
    
    public ItemType itemType;
    public string itemName;
    public int itemPrice;
    public sprite itemSprite;
    
}
