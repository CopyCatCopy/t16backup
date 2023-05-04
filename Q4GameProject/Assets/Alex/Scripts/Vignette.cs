using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vignette : MonoBehaviour
{
    public GameObject vignette;
    public GameObject cam;

    // Update is called once per frame
    void Update()
    {
        if (cam.activeSelf && vignette.activeSelf == false)
        {
            vignette.SetActive(true);
        }
        else
        {
            if (cam.activeSelf == false && vignette.activeSelf)
            {
                vignette.SetActive(false);
            }

        }
    }
}