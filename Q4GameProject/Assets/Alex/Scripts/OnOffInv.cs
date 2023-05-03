using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffInv : MonoBehaviour
{
    public GameObject inv;
    public GameObject text;
    public bool isOpen = false;
    public int FirstPerson = 0;
    public int ThirdPerson = 0;

    // Update is called once per frame
    void Update()
    {
        FirstPerson = PlayerPrefs.GetInt("FirstPerson");
        ThirdPerson = PlayerPrefs.GetInt("ThirdPerson");
        if (Input.GetKeyDown(KeyCode.I) && FirstPerson == 1)
        {
            if(isOpen == false)
            {
                text.SetActive(false);
                inv.SetActive(true);
                isOpen = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                text.SetActive(true);
                inv.SetActive(false);
                isOpen = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
            
        }
        //if (ThirdPerson == 1)
        //{
        //    text.SetActive(true);
        //    inv.SetActive(false);
        //    isOpen = false;
        //    Cursor.lockState = CursorLockMode.Locked;
        //    PlayerPrefs.SetInt("ThirdPerson", 1);
        //}

    }
}
