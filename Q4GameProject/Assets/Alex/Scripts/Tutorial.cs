using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject front;
    public GameObject back;
    public GameObject note;
    public GameObject x;
    public GameObject inventory;
    public GameObject timer;

    private void Start()
    {
        inventory.SetActive(false);
        timer.SetActive(false);
    }

    void Update()
    {
        if (note.activeSelf && Cursor.lockState != CursorLockMode.None)
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void Right()
    {
        back.SetActive(true);
        front.SetActive(false);
        x.SetActive(true);
    }

    public void Left()
    {
        back.SetActive(false);
        front.SetActive(true);
    }

    public void Exit()
    {
        note.SetActive(false);
        inventory.SetActive(true);
        timer.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
    }

}
