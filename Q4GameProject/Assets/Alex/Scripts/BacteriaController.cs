using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacteriaController : MonoBehaviour
{
    public GameObject ui;
    public Timer timer;
    public int counter;
    public GameObject sparkle;
    public bool complete;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(counter == 5)
        {
            complete = true;
            Invoke("Complete", .25f);
        }
    }

    public void Complete()
    {
        sparkle.SetActive(true);
        ui.SetActive(false);
        PlayerPrefs.SetInt("SinkMiniGameComplete", 1);
        timer.Invoke("Return", 2);
    }

}
