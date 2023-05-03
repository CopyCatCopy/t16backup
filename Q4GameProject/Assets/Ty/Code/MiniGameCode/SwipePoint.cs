using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipePoint : MonoBehaviour 
{
    private TearTask _tearTask;

    private Canvas _canvas;
    private void Awake()
    {
        _canvas = GetComponentInParent<Canvas>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        _tearTask.SwipePointTrigger(this);
    }
}
