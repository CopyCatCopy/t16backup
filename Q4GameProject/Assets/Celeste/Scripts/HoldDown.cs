using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HoldDown : MonoBehaviour
{

    public bool isPressed;
    public GameObject obj;
    public int WaterPercent = 0;
    public int DelayAmount = 1; // Second count
    protected float Timer;
    public Text percent;
    public GameObject obj2;


    void Start()
    {
        obj.SetActive(false);
        obj2.SetActive(false);
    }

    void Update()
    {
        Timer += Time.deltaTime;

    }

    public void OnMouseDown()
    {
        obj2.SetActive(true);
        isPressed = true;
        if (WaterPercent == 0)
        {
            percent.text = "0%";
        }

        if (Timer>= DelayAmount)
        {
            WaterPercent++;
        }
        if (WaterPercent == 1)
        {
            percent.text = "25%";
        }
        if (WaterPercent == 2)
        {
            percent.text = "50%";
        }
        if (WaterPercent == 3)
        {
            percent.text = "75%";
        }
    }
    public void OnMouseUp()
    {
        isPressed = false;
        if (WaterPercent == 4)
        {
            Debug.Log("Perfect Noodles You Win!!!");
            percent.text = "100%";
            obj.SetActive(true);
        }
    }

}
