using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{
    public ItemData itemData;

    public int onGridPositionX;
    public int onGridPositionY;
    public int id;
    public string itemName;
    
    


    public void Start()
    {
    
    }

    
    internal void Set(ItemData itemData)
    {
        this.itemData = itemData;

        GetComponent<Image>().sprite = itemData.itemIcon;

        Vector2 size = new Vector2();
        size.x = itemData.width * ItemGrid.tileSizeWidth;
        size.y = itemData.height * ItemGrid.tileSizeHeight;
        GetComponent<RectTransform>().sizeDelta = size;
    }

    public InventoryItem(int onGridPositionX, int onGridPositionY, int id, string itemName)
    {
        this.onGridPositionX = onGridPositionX;
        this.onGridPositionY = onGridPositionY;
        this.id = id;
        this.itemName = itemName;
    
    }
}
