using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameOn : MonoBehaviour
{
    public int MGameOn = 1;
    public int AlarmMiniGameOn = 0;
    public int SinkMiniGameOn = 0;
    public int FoodMiniGameOn = 0;
    public GameObject AlarmMiniGame;
    public GameObject MainGame;
    public GameObject SinkMiniGame;
    public GameObject FoodMiniGame;
    public int AlarmMiniGameFinished = 0;
    public int SinkMiniGameFinished = 0;
    public int FoodMiniGameFinished = 0;

    public void Update()
    {
        MGameOn = PlayerPrefs.GetInt("MGameOn");
        AlarmMiniGameOn = PlayerPrefs.GetInt("AlarmMiniGame");
        SinkMiniGameOn = PlayerPrefs.GetInt("SinkMiniGame");
        FoodMiniGameOn = PlayerPrefs.GetInt("FoodMiniGame");
        AlarmMiniGameFinished = PlayerPrefs.GetInt("AlarmMiniGameFinished");
        SinkMiniGameFinished = PlayerPrefs.GetInt("SinkMiniGameFinished");
        FoodMiniGameFinished = PlayerPrefs.GetInt("FoodMiniGameFinished");
        if (AlarmMiniGameOn == 1)
        {
            Debug.Log("#1");
        }

        if (MGameOn == 0)
        {
            Debug.Log("#2");
        }

        if(SinkMiniGameFinished == 0)
        {
            Debug.Log("#3");
        }
        if(SinkMiniGameOn == 1)
        {
            Debug.Log("#4");
        }
        if (MGameOn == 1)
        {
            Debug.Log("ITS ONNN");
        }

        if (MGameOn == 0 && AlarmMiniGameOn == 1 && AlarmMiniGameFinished == 0)
        {
            TurnOffMainScene();
            TurnOnAlarmMiniGame();
            MGameOn = 0;
            
        }
        if (MGameOn == 1 && AlarmMiniGameOn == 0 && AlarmMiniGameFinished == 1)
        {
            if (MGameOn == 1 && AlarmMiniGameOn == 0 && AlarmMiniGameFinished == 1)
            {
                TurnOnMainScene();
                TurnOffSinkMiniGame();
                MGameOn = 0;
                
            }
            TurnOnMainScene();
            TurnOffAlarmMiniGame();
            MGameOn = 0;
            
        }
        if (MGameOn == 0 && SinkMiniGameOn == 1 && SinkMiniGameFinished == 0)
        {
            Debug.Log("ITSS ALLIVEEE");
            TurnOffMainScene();
            TurnOnSinkMiniGame();
            MGameOn = 0;

        }
        if (MGameOn == 1 && SinkMiniGameOn == 0 && SinkMiniGameFinished == 1)
        {
            if (MGameOn == 1 && SinkMiniGameOn == 0 && SinkMiniGameFinished == 1)
            {
                TurnOnMainScene();
                TurnOffAlarmMiniGame();
                MGameOn = 0;
                
            }
            TurnOnMainScene();
            TurnOffSinkMiniGame();
            MGameOn = 0;
            
        }
        if (MGameOn == 0 && FoodMiniGameOn == 1 && FoodMiniGameFinished == 0)
        {
            Debug.Log("ITSS ALLIVEEE");
            TurnOffMainScene();
            TurnOnFoodMiniGame();
            MGameOn = 0;

        }
        if (MGameOn == 1 && FoodMiniGameOn == 0 && FoodMiniGameFinished == 1)
        {
            if (MGameOn == 1 && FoodMiniGameOn == 0 && FoodMiniGameFinished == 1)
            {
                TurnOnMainScene();
                TurnOffFoodMiniGame();
                MGameOn = 0;
                
            }
            TurnOnMainScene();
            TurnOffFoodMiniGame();
            MGameOn = 0;
            
        }

    }

            //MainGame
    public void TurnOnMainScene()
    {
        MainGame.SetActive(true);
    }

    public void TurnOffMainScene()
    {
        MainGame.SetActive(false);
    }

            //AlarmGame

    public void TurnOnAlarmMiniGame()
    {
        AlarmMiniGame.SetActive(true);
    } 

    public void TurnOffAlarmMiniGame()
    {
        AlarmMiniGame.SetActive(false);
    }

            //SinkGame

    public void TurnOnSinkMiniGame()
    {
        SinkMiniGame.SetActive(true);
    }

    public void TurnOffSinkMiniGame()
    {
        SinkMiniGame.SetActive(false);
    }

            //FoodGame

    public void TurnOnFoodMiniGame()
    {
        FoodMiniGame.SetActive(true);
    }

    public void TurnOffFoodMiniGame()
    {
        FoodMiniGame.SetActive(false);
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("MGameOn", 1);
        PlayerPrefs.SetInt("AlarmMiniGame", 0);
        PlayerPrefs.SetInt("SinkMiniGame", 0);
        PlayerPrefs.SetInt("GameFinished", 0);
    }
}
