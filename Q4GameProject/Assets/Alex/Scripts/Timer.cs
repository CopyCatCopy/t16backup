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

    private void Start()
    {
        time = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
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
        PlayerPrefs.SetInt("AlarmMiniGame", 0);
        PlayerPrefs.SetInt("SinkMiniGame", 0);
        PlayerPrefs.SetInt("GameFinished", 1);
        PlayerPrefs.SetInt("MGameOn", 1);
        if (timeAdded == false)
        {
            wt.time += 15;
            timeAdded = true;
        }
        
    }

    public void ReturnFailed()
    {
        Debug.Log("Returning");
        PlayerPrefs.SetInt("AlarmMiniGame", 0);
        PlayerPrefs.SetInt("SinkMiniGame", 0);
        PlayerPrefs.SetInt("GameFinished", 1);
        PlayerPrefs.SetInt("BedUsed", 1);
        PlayerPrefs.SetInt("MGameOn", 1);
        PlayerPrefs.SetInt("AlarmMiniGameWinComplete", 0);
        PlayerPrefs.SetInt("SinkMiniGameWinComplete", 0);

    }
}
