using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAlarm : MonoBehaviour
{
    public Animator alarm;
    public GameObject offonswitch;
    public GameObject alarmClock;
    public GameObject completeAlarm;
    public GameObject ui;
    public bool complete;
    public ParticleSystem sparkle;
    public Timer timer;
    public AudioSource audioSource;
    private void Start()
    {
        
    }

    public void RotateRight()
    {
        if (alarm.GetBool("facingFront"))
        {
            alarm.SetBool("facingRight", true);
            alarm.SetBool("facingFront", false);
        }
        else if (alarm.GetBool("facingRight"))
        {
            alarm.SetBool("facingBack", true);
            alarm.SetBool("facingRight", false);
        }
        else if (alarm.GetBool("facingBack"))
        {
            alarm.SetBool("facingLeft", true);
            alarm.SetBool("facingBack", false);
        }
        else if (alarm.GetBool("facingLeft"))
        {
            alarm.SetBool("facingFront", true);
            alarm.SetBool("facingLeft", false);
        }
    }

    public void RotateLeft()
    {
        if (alarm.GetBool("facingFront"))
        {
            alarm.SetBool("facingLeft", true);
            alarm.SetBool("facingFront", false);
        }
        else if (alarm.GetBool("facingLeft"))
        {
            alarm.SetBool("facingBack", true);
            alarm.SetBool("facingLeft", false);
        }
        else if (alarm.GetBool("facingBack"))
        {
            alarm.SetBool("facingRight", true);
            alarm.SetBool("facingBack", false);
        }
        else if (alarm.GetBool("facingRight"))
        {
            alarm.SetBool("facingFront", true);
            alarm.SetBool("facingRight", false);
        }
    }

    void Update()
    {
        if (alarm.GetBool("facingBack"))
        {
            offonswitch.SetActive(true);
        }
        else
        {
            offonswitch.SetActive(false);
        }

        if (complete == true)
        {
            Invoke("Complete", .25f);
        }
    }

    public void Complete()
    {
        ui.SetActive(false);
        alarmClock.SetActive(false);
        offonswitch.SetActive(false);
        completeAlarm.SetActive(true);
        PlayerPrefs.SetInt("AlarmMiniGameComplete", 1);
        timer.Invoke("Return", 2);
    }

    public void Click()
    {
        audioSource.Play();
    }

}
