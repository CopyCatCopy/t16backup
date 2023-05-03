using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        if(Time.timeScale != 1)
        {
            Time.timeScale = 1;
        }
        //if()
    }

    public void PlayGame()
    {
        PlayerPrefs.SetInt("ActivateGame", 0);
        PlayerPrefs.SetInt("SceneChanged", 0);
        Invoke("Play", .5f);
    }

    public void Play()
    {
        //added for sfx and transitions
        Debug.Log("Start");
        SceneManager.LoadScene("MainScene");
    }

    public void QuitGame()
    {
        Invoke("Quit", .25f);
    }

    public void Quit()
    {
        //added for sfx and transitions
        Debug.Log("Quit");
        Application.Quit();
    }

    public void LoadCredits()
    {
        Invoke("Credits", .25f);
    }

    public void Credits()
    {
        //added for sfx and transitions
        SceneManager.LoadScene("CS1");
    }

    public void LoadOptions()
    {
        Invoke("Options", .25f);
    }

    public void Options()
    {
        //added for sfx and transitions
        SceneManager.LoadScene("OptionsMenu");
    }

    public void LoadAlarmMiniGame()
    {
        SceneManager.LoadScene("MiniGame1");
    }

    public void LoadSinkMiniGame()
    {
        SceneManager.LoadScene("MiniGame2");
    }

}