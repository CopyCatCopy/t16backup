using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScene : MonoBehaviour
{
    public void ReturnToMenu()
    {
        Invoke("ToMenu", .25f);
    }

    public void ToMenu()
    {
        //added for sfx
        SceneManager.LoadScene("Menu");
    }

    public void NextScreen()
    {
        Invoke("Next", .25f);
    }

    public void Next()
    {
        //added for sfx
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PreviousScreen()
    {
        Invoke("Previous", .25f);
    }

    public void Previous()
    {
        //added for sfx
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
