using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ItemData : ScriptableObject
{
    public int width = 1;
    public int height = 1;

    public Sprite itemIcon;

    public int id;
    public string itemName;

    public ItemData(int id, string itemName)
    {
        this.id = id;
        this.itemName = itemName;
    }

}
