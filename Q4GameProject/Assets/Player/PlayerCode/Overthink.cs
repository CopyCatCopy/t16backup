using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overthink : MonoBehaviour
{
    public GameObject Timer;
    public bool Overthinking;

    public void Intensify()
    {
        if( GetComponent<SwitchPerspective>().FirstPersonCameraOn == true)
        {
            Timer.GetComponent<WorldTimer>().Overthinking = true;
            Overthinking = true;
        }
        else if (GetComponent<SwitchPerspective>().FirstPersonCameraOn == false)
        {
            Timer.GetComponent<WorldTimer>().Overthinking = false;
            Overthinking = false;
        }
    }
}
