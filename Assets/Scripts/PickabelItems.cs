using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickabelItems : MonoBehaviour
{
    public ScriptableItems item;
    SpriteRenderer spriterenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer> ();
        spriteRenderer.sprite = item.itemSprites;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        InventoryManager.instance.AddItem(item);
        Destroy(this.gameObject);
    }
}
