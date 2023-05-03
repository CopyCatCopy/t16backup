using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventroy System/Inventory")]
public class InventoryObject : ScriptableObject
{
    public List<InventorySlot> Container = new List<InventorySlot>();
    public void AddItem(ItemObject _item, int _gridvalueX, int _gridvalueY)
    {
        Container.Add(new InventorySlot(_item, _gridvalueX, _gridvalueY));
    }
}

[System.Serializable]
public class InventorySlot
{
    public ItemObject item;
    public int gridvalueX;
    public int gridvalueY;
    public InventorySlot(ItemObject _item, int _gridvalueX, int _gridvalueY)
    {
        item = _item;
        gridvalueX = _gridvalueX;
        gridvalueY = _gridvalueY;

}
}
