using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextBox : MonoBehaviour
{
    public GameObject box;
    public GameObject newbox;
    public GameObject end;
    public GameObject button;

    public void Next()
    {
        if (box.activeSelf == false)
        {
            Invoke("On", 1f);
        }
    }

    public void On()
    {
        newbox.SetActive(true);
    }

    public void NextTwo()
    {
        if (newbox.activeSelf == false)
        {
            Invoke("Ending", 1f);
            Invoke("Ending2", 12f);
        }
    }

    public void Ending()
    {
        end.SetActive(true);
    }

    public void Ending2()
    {
        button.SetActive(true);
    }

}
