using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    public ScriptableItems [] weapons;

    public text [] weaponsNames;
    public image [] weaponesSprites;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    public void AddItem (ScriptableItem item)
    {
        for (int i = 0; i < weapons.Length; i++)   
        {
            if (weapons [i] == null)
            {
                weapons [i] = item;
                weaponsNames [i].text = item.itemName;
                weaponesSprites [i].sprite = item.itemSprites;

                return;
            }
        }
    }
}
