using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCalculator : MonoBehaviour
{
    public int AlarmMiniGameComplete = 0;
    public int AlarmMiniGameCompleteAmount = 0;
    public int SinkMiniGameComplete = 0;
    public int SinkMiniGameCompleteAmount = 0;
    public int FoodMiniGameComplete = 0;
    public int FoodMiniGameCompleteAmount = 0;
    public int MiniGameSet = 0;
    public int AlarmMiniGameFinished = 0;
    public int SinkMiniGameFinished = 0;
    public int FoodMiniGameFinished = 0;


    public bool Changing = false;
    // Update is called once per frame
    public void Update()
    {

        AlarmMiniGameComplete = PlayerPrefs.GetInt("AlarmMiniGameComplete");
        SinkMiniGameComplete = PlayerPrefs.GetInt("SinkMiniGameComplete");
        FoodMiniGameComplete = PlayerPrefs.GetInt("FoodMiniGameComplete");
        AlarmMiniGameCompleteAmount = PlayerPrefs.GetInt("AlarmMiniGameWinAmount");
        SinkMiniGameCompleteAmount = PlayerPrefs.GetInt("SinkMiniGameWinAmount");
        FoodMiniGameCompleteAmount = PlayerPrefs.GetInt("FoodMiniGameWinAmount");
        AlarmMiniGameFinished = PlayerPrefs.GetInt("AlarmMiniGameFinished");
        SinkMiniGameFinished = PlayerPrefs.GetInt("SinkMiniGameFinished");
        FoodMiniGameFinished = PlayerPrefs.GetInt("FoodMiniGameFinished");
        MiniGameSet = PlayerPrefs.GetInt("MiniGameSet");
        if ( MiniGameSet == 1)
        {
            Debug.Log("#8");
        }
        if (AlarmMiniGameFinished == 1)
        {
            Debug.Log("#9");
        }

        if ( AlarmMiniGameComplete == 1 && Changing == false && MiniGameSet == 1 && AlarmMiniGameFinished == 1)
        {
            AlarmMiniGameCompleteAmount++;
            PlayerPrefs.SetInt("AlarmMiniGameWinAmount", AlarmMiniGameCompleteAmount);
            PlayerPrefs.SetInt("AlarmMiniGameFinished", 0);
            PlayerPrefs.SetInt("MiniGameSet", 0);
            Debug.Log(AlarmMiniGameCompleteAmount);
            Changing = true;
            Invoke("Changed", 3f);
        }
        if( SinkMiniGameComplete == 1 && Changing == false && MiniGameSet == 1 && SinkMiniGameFinished == 1)
        {
            SinkMiniGameCompleteAmount++;
            PlayerPrefs.SetInt("SinkMiniGameWinAmount", SinkMiniGameCompleteAmount);
            PlayerPrefs.SetInt("SinkMiniGameFinished", 0);
            PlayerPrefs.SetInt("MiniGameSet", 0);
            Debug.Log(SinkMiniGameCompleteAmount);
            Changing = true;
            Invoke("Changed", 1f);
        }
        if (AlarmMiniGameComplete == 0 && Changing == false && MiniGameSet == 1 && AlarmMiniGameFinished == 1)
        {
            AlarmMiniGameCompleteAmount--;
            PlayerPrefs.SetInt("AlarmMiniGameWinAmount", AlarmMiniGameCompleteAmount);
            PlayerPrefs.SetInt("AlarmMiniGameFinished", 0);
            PlayerPrefs.SetInt("MiniGameSet", 0);
            Debug.Log(AlarmMiniGameCompleteAmount);
            Changing = true;
            Invoke("Changed", 1f);
        }
        if (SinkMiniGameComplete == 0 && Changing == false && MiniGameSet == 1 && SinkMiniGameFinished == 1)
        {
            SinkMiniGameCompleteAmount--;
            PlayerPrefs.SetInt("SinkMiniGameWinAmount", SinkMiniGameCompleteAmount);
            PlayerPrefs.SetInt("SinkMiniGameFinished", 0);
            PlayerPrefs.SetInt("MiniGameSet", 0);
            Debug.Log(SinkMiniGameCompleteAmount);
            Changing = true;
            Invoke("Changed", 1f);
        }
        if (AlarmMiniGameCompleteAmount > 3 && SinkMiniGameCompleteAmount > 3 && FoodMiniGameCompleteAmount > 3)
        {
            PlayerPrefs.SetInt("AllTasksComplete", 1);
        }
        
    }


    public void Changed()
    {
        Changing = false;
    }
}
