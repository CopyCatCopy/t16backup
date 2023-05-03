using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    public GameObject note;
    public int AlarmMiniGameComplete = 0;
    public int SinkMiniGameComplete = 0;
    private void Start()
    {
       
    }

    void Update()
    {
        AlarmMiniGameComplete = PlayerPrefs.GetInt("AlarmMiniGameComplete");
        SinkMiniGameComplete = PlayerPrefs.GetInt("SinkMiniGameComplete");
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("C is Good");
            if (note.activeInHierarchy)
            {
                Close();
            }
            if (note.activeSelf == false)
            {
                Open();
            }
        }
    }

    public void Open()
    {
        note.SetActive(true);
    }
    public void Close()
    {
        note.SetActive(false);
    }
}
