using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TipController : MonoBehaviour
{
    public Text tip;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("doorway"))
        {
            tip.text = string.Format("' F ' to open");
        }
        else if (other.CompareTag("hall"))
        {
            tip.text = string.Format("' Shift ' to switch perspective");
        }
        else if (other.CompareTag("bookshelf"))
        {
            tip.text = string.Format("' F ' to collect");
        }
        else if (other.CompareTag("start"))
        {
            tip.text = string.Format("'WASD' to move");
        }

    }

    void OnTriggerExit(Collider other)
    {
        tip.text = string.Format("");
    }
}

