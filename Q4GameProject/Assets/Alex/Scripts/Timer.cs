using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float time;
    public float maxTime;
    public Image timer;
    public GameObject ui;
    public GameObject failText;
    public GameObject other;
    public WorldTimer wt;
    public bool timeAdded = false;
    public int AlarmMiniGame = 0;
    public int SinkMiniGame = 0;
    public int FoodMiniGame = 0;

    private void Start()
    {
        time = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        AlarmMiniGame = PlayerPrefs.GetInt("AlarmMiniGame");
        SinkMiniGame = PlayerPrefs.GetInt("SinkMiniGame");
        FoodMiniGame = PlayerPrefs.GetInt("FoodMiniGame");
        if (time > 0)
        {
            time -=Time.deltaTime;
            timer.fillAmount = time / maxTime;
        }
        else
        {
            time = 0;
        }

        if (time == 0)
        {
            if (other != null)
            {
                other.SetActive(false);
            }
            ui.SetActive(false);
            failText.SetActive(true);
            Invoke("ReturnFailed", 2);
        }
    }

    public void Return()
    {
        Debug.Log("Returning");
        if (AlarmMiniGame == 1)
        {
            PlayerPrefs.SetInt("AlarmMiniGame", 0);
            PlayerPrefs.SetInt("AlarmMiniGameFinished", 1);
        }
        if (SinkMiniGame == 1)
        {
            PlayerPrefs.SetInt("SinkMiniGame", 0);
            PlayerPrefs.SetInt("SinkMiniGameFinished", 1);
        }
        if (FoodMiniGame == 1)
        {
            PlayerPrefs.SetInt("FoodMiniGame", 0);
            PlayerPrefs.SetInt("FoodMiniGameFinished", 1);
        }
        PlayerPrefs.SetInt("MGameOn", 1); 
        PlayerPrefs.SetInt("MiniGameSet", 1);
        if (timeAdded == false)
        {
            wt.time += 15;
            timeAdded = true;
        }
        
    }

    public void ReturnFailed()
    {
        Debug.Log("Returning");
        if (AlarmMiniGame == 1)
        {
            PlayerPrefs.SetInt("AlarmMiniGame", 0);
            PlayerPrefs.SetInt("AlarmMiniGameFinished", 1);
        }
        if (SinkMiniGame == 1)
        {
            PlayerPrefs.SetInt("SinkMiniGame", 0);
            PlayerPrefs.SetInt("SinkMiniGameFinished", 1);
        }
        if (FoodMiniGame == 1)
        {
            PlayerPrefs.SetInt("FoodMiniGame", 0);
            PlayerPrefs.SetInt("FoodMiniGameFinished", 1);
        }
        PlayerPrefs.SetInt("MiniGameSet", 1);
        PlayerPrefs.SetInt("BedUsed", 1);
        PlayerPrefs.SetInt("MGameOn", 1);
    }
}
