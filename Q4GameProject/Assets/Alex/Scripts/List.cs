using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    public GameObject note;
    public int AlarmMiniGameComplete = 0;
    public int SinkMiniGameComplete = 0;
    public int FoodMiniGameComplete = 0;
    public bool SetAlarm = false;
    public bool BrushTeeth = false;
    public bool EatFood = false;

    public GameObject AlarmChecked;
    public GameObject SinkChecked;
    public GameObject FoodChecked;
    private void Start()
    {
       
    }

    void Update()
    {
        AlarmMiniGameComplete = PlayerPrefs.GetInt("AlarmMiniGameComplete");
        SinkMiniGameComplete = PlayerPrefs.GetInt("SinkMiniGameComplete");
        FoodMiniGameComplete = PlayerPrefs.GetInt("FoodMiniGameComplete");

        if (AlarmMiniGameComplete == 1)
        {
            SetAlarm = true;
        }
        if (SinkMiniGameComplete == 1)
        {
            BrushTeeth = true;
        }
        if (FoodMiniGameComplete == 1)
        {
            EatFood = true;
        }

        if (SetAlarm == true)
        {
            AlarmChecked.SetActive(true);
        }
        if (BrushTeeth == true)
        {
            SinkChecked.SetActive(true);
        }
        if (EatFood == true)
        {
            FoodChecked.SetActive(true);
        }

    }

    public void Close()
    {
        note.SetActive(false);
    }
}
