using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static Vector3 playerPosition;
    public bool miniGame01Complete;
    public bool miniGame02Complete = false;
    public bool miniGame03Complete = false;
    public bool miniGame04Complete = false;
    public int itemIDinInv;
    public HeldData Data;

    //public List<Item> TotalItems = new List<Item>();
    //public List<Item> InventoryItems = new List<Item>();

    //Item Battery = new Item("Battery", 0);
    //Item Toothpaste = new Item("Toothpaste", 1);
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckData()
    {
        if (GetComponent<RotateAlarm>().complete == true)
        {
            miniGame01Complete = true;
        }
        if (GetComponent<RotateAlarm>().complete == true)
        {
            miniGame01Complete = true;
        }
        if (GetComponent<RotateAlarm>().complete == true)
        {
            miniGame01Complete = true;
        }

    }

    private void OnDestroy()
    {
        Data.MiniGame01Complete = miniGame01Complete;
        Data.MiniGame02Complete = miniGame02Complete;
        Data.MiniGame03Complete = miniGame03Complete;
        Data.MiniGame04Complete = miniGame04Complete;
        
    }
}
