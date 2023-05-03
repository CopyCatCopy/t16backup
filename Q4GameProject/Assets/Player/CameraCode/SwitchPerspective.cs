using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPerspective : MonoBehaviour
{
    public bool FirstPersonCameraOn;
    public bool ThirdPersonCameraOn;
    public GameObject FirstPersonCamera;
    public GameObject JunoFront;
    public int Basement = 0;

    // Start is called before the first frame update
    void Start()
    {
        ThirdPersonCameraOn = true;
        FirstPersonCameraOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        Basement = PlayerPrefs.GetInt("Basement");
        if (Input.GetKeyDown(KeyCode.LeftShift) && ThirdPersonCameraOn == true && Basement == 0)
        {
            ThirdPersonCameraOn = false;
            FirstPersonCameraOn = true;
            Switch();
            GetComponent<Overthink>().Intensify();
            PlayerPrefs.SetInt("FirstPerson", 1);
        }
        else if (Input.GetKeyDown(KeyCode.LeftShift) && FirstPersonCameraOn == true && Basement == 0)
        {
            FirstPersonCameraOn = false;
            ThirdPersonCameraOn = true;
            Switch();
            GetComponent<Overthink>().Intensify();
            PlayerPrefs.SetInt("FirstPerson", 0);
            PlayerPrefs.SetInt("ThirdPerson", 1);
        }
        if (Basement == 1)
        {
            ThirdPersonCameraOn = false;
            FirstPersonCameraOn = true;
            Switch();
            GetComponent<Overthink>().Intensify();
            PlayerPrefs.SetInt("FirstPerson", 1);
        }



    }


    public void Switch()
    {
        if (ThirdPersonCameraOn == true)
        {
            FirstPersonCamera.SetActive(false);
            FirstPersonCamera.GetComponentInChildren<CameraRotation>().RotationOn = false;
            FirstPersonCamera.GetComponentInChildren<CameraRotation>().CameraTurnOn();
            GetComponent<MovementScript>().CameraRotationOn = false;
            GetComponent<MovementScript>().RotationOn();
            JunoFront.SetActive(true);
            
        }
        else if (FirstPersonCameraOn == true)
        {
            FirstPersonCamera.SetActive(true);
            FirstPersonCamera.GetComponentInChildren<CameraRotation>().RotationOn = true;
            FirstPersonCamera.GetComponentInChildren<CameraRotation>().CameraTurnOn();
            GetComponent<MovementScript>().CameraRotationOn = true;
            GetComponent<MovementScript>().RotationOn();
            JunoFront.SetActive(false);
            
        }
    }
    private void OnDestroy()
    {
        PlayerPrefs.SetInt("FirstPerson", 0);
        PlayerPrefs.SetInt("Basement", 0);
    }
}
