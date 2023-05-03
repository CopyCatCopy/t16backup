using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingButton : MonoBehaviour
{
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Activate", 12f);   
    }

    public void Activate()
    {
        button.SetActive(true);
    }
}
