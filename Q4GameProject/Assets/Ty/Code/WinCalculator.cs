using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCalculator : MonoBehaviour
{
    public int AlarmMiniGameComplete = 0;
    public int AlarmMiniGameCompleteAmount = 0;
    public int SinkMiniGameComplete = 0;
    public int SinkMiniGameCompleteAmount = 0;
    // Update is called once per frame
    public void Update()
    {

        AlarmMiniGameComplete = PlayerPrefs.GetInt("AlarmMiniGameComplete");
        SinkMiniGameComplete = PlayerPrefs.GetInt("SinkMiniGameComplete");
        AlarmMiniGameCompleteAmount = PlayerPrefs.GetInt("AlarmMiniGameWinAmount");
        SinkMiniGameCompleteAmount = PlayerPrefs.GetInt("SinkMiniGameWinAmount");

        if ( AlarmMiniGameComplete == 1)
        {
            PlayerPrefs.SetInt("AlarmMiniGameWinAmount", 1);
            Debug.Log(AlarmMiniGameCompleteAmount);
        }
        if( SinkMiniGameComplete == 1)
        {
            PlayerPrefs.SetInt("SinkMiniGameWinAmount", 1);
            Debug.Log(SinkMiniGameCompleteAmount);
        }
        if (AlarmMiniGameComplete == 0)
        {
            PlayerPrefs.SetInt("AlarmMiniGameWinAmount", 0);
            Debug.Log(AlarmMiniGameCompleteAmount);
        }
        if (SinkMiniGameComplete == 0)
        {
            PlayerPrefs.SetInt("SinkMiniGameWinAmount", 0);
            Debug.Log(SinkMiniGameCompleteAmount);
        }
        if (AlarmMiniGameCompleteAmount > 0 && SinkMiniGameCompleteAmount > 0)
        {
            PlayerPrefs.SetInt("AllTasksComplete", 1);
        }
        
    }
}
