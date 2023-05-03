using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmOn : MonoBehaviour
{
    public RotateAlarm ra;
    public AudioSource audioSource;

    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        ra.complete = true;
        audioSource.Play();
    }
}
