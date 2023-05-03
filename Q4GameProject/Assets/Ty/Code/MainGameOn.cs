using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameOn : MonoBehaviour
{
    public int MGameOn = 1;
    public int AlarmMiniGameOn = 0;
    public int SinkMiniGameOn = 0;
    public int CookingMiniGameOn = 0;
    public GameObject AlarmMiniGame;
    public GameObject MainGame;
    public GameObject SinkMiniGame;
    public int GameFinished = 0;

    public void Update()
    {
        MGameOn = PlayerPrefs.GetInt("MGameOn");
        AlarmMiniGameOn = PlayerPrefs.GetInt("AlarmMiniGame");
        SinkMiniGameOn = PlayerPrefs.GetInt("SinkMiniGame");
        GameFinished = PlayerPrefs.GetInt("GameFinished");
        if(AlarmMiniGameOn == 1)
        {
            Debug.Log("#1");
        }

        if (MGameOn == 0)
        {
            Debug.Log("#2");
        }

        if(GameFinished == 0)
        {
            Debug.Log("#3");
        }
        if(SinkMiniGameOn == 1)
        {
            Debug.Log("#4");
        }

        if (MGameOn == 0 && AlarmMiniGameOn == 1 && GameFinished == 0)
        {
            TurnOffMainScene();
            TurnOnAlarmMiniGame();
            MGameOn = 0;
            
        }
        if (MGameOn == 1 && AlarmMiniGameOn == 0 && GameFinished == 1)
        {
            if (MGameOn == 1 && SinkMiniGameOn == 0 && GameFinished == 1)
            {
                TurnOnMainScene();
                TurnOffSinkMiniGame();
                MGameOn = 0;
                PlayerPrefs.SetInt("GameFinished", 0);
            }
            TurnOnMainScene();
            TurnOffAlarmMiniGame();
            MGameOn = 0;
            PlayerPrefs.SetInt("GameFinished", 0);
        }
        if (MGameOn == 0 && SinkMiniGameOn == 1 && GameFinished == 0)
        {
            Debug.Log("ITSS ALLIVEEE");
            TurnOffMainScene();
            TurnOnSinkMiniGame();
            MGameOn = 0;

        }
        if (MGameOn == 1 && SinkMiniGameOn == 0 && GameFinished == 1)
        {
            if (MGameOn == 1 && SinkMiniGameOn == 0 && GameFinished == 1)
            {
                TurnOnMainScene();
                TurnOffAlarmMiniGame();
                MGameOn = 0;
                PlayerPrefs.SetInt("GameFinished", 0);
            }
            TurnOnMainScene();
            TurnOffSinkMiniGame();
            MGameOn = 0;
            PlayerPrefs.SetInt("GameFinished", 0);
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

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("MGameOn", 1);
        PlayerPrefs.SetInt("AlarmMiniGame", 0);
        PlayerPrefs.SetInt("SinkMiniGame", 0);
        PlayerPrefs.SetInt("GameFinished", 0);
    }
}
