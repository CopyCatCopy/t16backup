using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F1))
        {
            Screen.SetResolution(1920, 1200, Screen.fullScreen);
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            Screen.SetResolution(1600, 900, Screen.fullScreen);
        }

        if (Input.GetKeyDown(KeyCode.F3))
        {
            Screen.SetResolution(1280, 800, Screen.fullScreen);
        }

        if (Input.GetKeyDown(KeyCode.F4))
        {
            Screen.SetResolution(1366, 768, false);
        }
    }
}
