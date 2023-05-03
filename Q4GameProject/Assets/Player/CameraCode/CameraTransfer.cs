using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransfer : MonoBehaviour
{
    public GameObject RoomCamera1;
    public GameObject RoomCamera2;
    public GameObject Player;
    public bool isInside;
    
    

    private void OnTriggerEnter(Collider other)
    {
        if (Player)
        {
            RoomCamera1.SetActive(false);
            RoomCamera2.SetActive(true);
            isInside = true;
           

        }  
    }

    private void OnTriggerStay(Collider other)
    {
        RoomCamera2.SetActive(true);
        isInside = true;
    }

    private void OnTriggerExit(Collider other)
    {
        RoomCamera2.SetActive(false);
        isInside = false;
    }
}
   

