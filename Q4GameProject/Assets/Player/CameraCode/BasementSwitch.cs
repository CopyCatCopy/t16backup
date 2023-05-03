using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasementSwitch : MonoBehaviour
{
    public GameObject FirstPersonCamera;
    
    public GameObject Player;
    public bool isInside;



    private void OnTriggerEnter(Collider other)
    {
        if (Player)
        {
            FirstPersonCamera.SetActive(true);
            isInside = true;
            PlayerPrefs.SetInt("FirstPerson", 1);
            PlayerPrefs.SetInt("Basement", 1);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        FirstPersonCamera.SetActive(false);
        isInside = false;
        PlayerPrefs.SetInt("Basement", 0);

    }
}
