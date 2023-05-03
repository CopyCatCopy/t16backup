using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    public GameObject fIn;
    public GameObject fOut;

    private void Start()
    {
        Invoke("FadeOut", .5f);
    }
    public void FadeIn()
    {
        fIn.SetActive(true);
    }

    public void FadeOut()
    {
        fOut.SetActive(false);
    }

}
