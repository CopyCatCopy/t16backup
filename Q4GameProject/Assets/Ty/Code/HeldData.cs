using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class HeldData : ScriptableObject
//[]

{
    private Vector3 playerPosition;
    private bool miniGame01Complete = false;
    private bool miniGame02Complete = false;
    private bool miniGame03Complete = false;
    private bool miniGame04Complete = false;
    private int itemIDinInv;

    
   
    public Vector3 PlayerPosition 
    { 
        get => playerPosition; 
        set => playerPosition = value; 
    }
    public bool MiniGame01Complete 
    { 
        get => miniGame01Complete; 
        set => miniGame01Complete = value; 
    }
    public bool MiniGame02Complete 
    { 
        get => miniGame02Complete; 
        set => miniGame02Complete = value; 
    }
    public bool MiniGame03Complete 
    { 
        get => miniGame03Complete; 
        set => miniGame03Complete = value; 
    }
    public bool MiniGame04Complete 
    { 
        get => miniGame04Complete; 
        set => miniGame04Complete = value; 
    }
    public int ItemIDinInv 
    { 
        get => itemIDinInv; 
        set => itemIDinInv = value; 
    }

}
