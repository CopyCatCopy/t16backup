using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WorldTimer : MonoBehaviour
{
    public float time;
    public Text timeText;
    public int DayNumber = 1;
    public int AllTasksComplete = 0;
    public bool Overthinking;
    public float AddingDelay = 5f;
    public bool DelayBool;
    public int ActivateGame = 1;
    public int SceneChanged = 0;
    public float LoadedTime;
    public int SavedTime = 0;
    public bool SceneSwitched = true;
    public int BedUsed;
    public GameObject Tutorial;

    void Start()
    {
        ActivateGame = PlayerPrefs.GetInt("ActivateGame");
        AllTasksComplete = PlayerPrefs.GetInt("AllTasksComplete");
        Debug.Log(ActivateGame);
        if (ActivateGame == 1)
        {
            SceneChanged = PlayerPrefs.GetInt("SceneChanged");
            Debug.Log(SceneChanged);
            Debug.Log("Loadded Game");
            LoadTime();
            if (SceneChanged == 0)
            { 
                Debug.Log("FUCCAAAAAAAA");
                Debug.Log(ActivateGame);
                Debug.Log(DayNumber);
                Days();
            }
        }
        else if (ActivateGame == 0)
        {
            Debug.Log("Resetted Game");
            ResetTheScene();
            PlayerPrefs.SetInt("ResetDataBool", 1);
        }
        

    }
    // Update is called once per frame
    void Update()
    {
        BedUsed = PlayerPrefs.GetInt("BedUsed");
        if (time > 0 && Overthinking == false)
        {
            time -= Time.deltaTime;
        }
        if (time > 0 && Overthinking == true)
        {
            time -= Time.deltaTime * 2f;
        }
        //else
        //{
        //    time = 0;
        //}
        DisplayTime(time);

        if(BedUsed == 1)
        {
            AddDay();
            PlayerPrefs.SetInt("BedUsed", 0);
        }
    }


    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (time < 0)
        {
            Debug.Log("Time End");
            AddDay();
            //DelayBool = true;
        }
        

    }


                    //Day System Code


    //Adds a day after the Timer resets
    public void AddDay()
    {
        //if (DelayBool == false)
        //{
            DayNumber++;
            Debug.Log(DayNumber);
            PlayerPrefs.SetInt("Days", DayNumber);
            Debug.Log(DayNumber);
            ResetTheDay();
            Days();
       // }
    }

    void Days()
    {
        
        DayNumber = PlayerPrefs.GetInt("Days");
        Debug.Log(DayNumber);
        if (DayNumber == 1)
        {
            time = 320;
            Tutorial.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
        if (DayNumber == 2)
        {

            time = 240;
        }
        if (DayNumber == 3)
        {

            time = 200;
        }
        if (DayNumber == 4)
        {

            time = 160;
        }
        if (DayNumber == 5)
        {

            time = 120;
        }
        if (DayNumber == 6 && AllTasksComplete == 1)
        {
            SceneManager.LoadScene("GoodEnding");
            Cursor.lockState = CursorLockMode.None;
        }
        if (DayNumber == 6 && AllTasksComplete == 0)
        {
            SceneManager.LoadScene("BadEnding");
            Cursor.lockState = CursorLockMode.None;
        }
    }

    //Overall Reset

    public void ResetTheScene()
    {
        PlayerPrefs.SetInt("ActivateGame", 1);
        PlayerPrefs.SetFloat("Time", 0);
        PlayerPrefs.SetInt("Days", 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    //Day Reset

    public void ResetTheDay()
    {
        PlayerPrefs.SetFloat("Time", 0);
        PlayerPrefs.SetInt("ResetDataBool", 1);
        DelayBool = true;
        SceneManager.LoadScene("Sleep");
    }

    //Saving Time Data



    //When Scene is closed, Data Saves Time of Scene
    private void OnDestroy()
    {
        SavedTime = PlayerPrefs.GetInt("SavedTime");
        Debug.Log(PlayerPrefs.GetInt("SceneChanged"));
        PlayerPrefs.SetInt("SceneChanged", 0);
        if (SavedTime == 1)
        {
            SaveTime();
            
        }
        
    }


    //Saves the current time on the Scene
    public void SaveTime()
    {
        Debug.Log("Time Saved");
        PlayerPrefs.SetFloat("Time", time);
        Debug.Log(PlayerPrefs.GetFloat("Time"));
        PlayerPrefs.SetInt("SavedTime", 0);

        
        

    }

    //Loads the past current time on the Scene
    public void LoadTime()
    {
        Debug.Log("Time Loaded");
        time = PlayerPrefs.GetFloat("Time");
        PlayerPrefs.SetInt("SavedTime", 1);

    }




}