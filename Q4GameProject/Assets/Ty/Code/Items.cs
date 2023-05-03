using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item", fileName = "New Item")]
public class Items : ScriptableObject
{
    public string Name;
    public int itemID;

    //public UnityEngine.Events.UnityEvent<ItemRequires> requires;

    UnityEngine.Events.UnityEvent onUse;
}
