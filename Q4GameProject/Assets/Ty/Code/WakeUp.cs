using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WakeUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SceneSwitch", 5f);
    }


    public void SceneSwitch()
    {
        SceneManager.LoadScene("MainScene");
    }
}
