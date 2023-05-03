using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Useable Object", menuName = "Inventory System/Items/Useable")]
public class UseableObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.Useables;
    }
}
