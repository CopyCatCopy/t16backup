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
    public Animator anim;
    public Timer timer;
    public GameObject water;
    public GameObject clear;
    public GameObject ui;
    public Animator ball;

    void Start()
    {
        
    }

    void Update()
    {

    }

    public void OnMouseDown()
    {
        obj2.SetActive(true);
        isPressed = true;

        if (WaterPercent <= 4)
        {
            WaterPercent++;
            if (WaterPercent == 0)
            {
                percent.text = "0%";
                
            }
            
            if (WaterPercent == 1)
            {
                percent.text = "25%";
                water.SetActive(true);
                ball.SetBool("stage2", true);
            }
            if (WaterPercent == 2)
            {
                percent.text = "50%";
                anim.SetBool("Water", true);
                water.SetActive(false);
                ball.SetBool("stage2", false);
                ball.SetBool("stage3", true);
            }
            if (WaterPercent == 3)
            {
                percent.text = "75%";
                anim.SetBool("Close", true);
                anim.SetBool("Water", false);
                ball.SetBool("stage4", true);
                ball.SetBool("stage3", false);
            }
        }

    }
    public void OnMouseUp()
    {
        isPressed = false;
        if (WaterPercent == 4)
        {
            obj.SetActive(false);
            ui.SetActive(false);
            clear.SetActive(true);
            anim.SetBool("Open", true);
            anim.SetBool("Close", false);
            Debug.Log("Perfect Noodles You Win!!!");
            percent.text = "100%";
            timer.Invoke("Return", 2f);
            PlayerPrefs.SetInt("FoodMiniGameComplete", 1);
        }
    }

    //public void PercentUp()
    //{
    //    WaterPercent++;
    //}

    //public void Button1()
    //{
    //    button1.SetActive(false);
    //    button2.SetActive(true);
    //    WaterPercent++;
    //}

    //public void Button2()
    //{
    //    button2.SetActive(false);
    //    button3.SetActive(true);
    //    WaterPercent++;
    //}

    //public void Button3()
    //{
    //    button3.SetActive(false);
    //    button4.SetActive(true);
    //    WaterPercent++;
    //}

    //public void Button4()
    //{
    //    button4.SetActive(false);
    //    WaterPercent++;
    //}

}
