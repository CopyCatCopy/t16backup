using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{

    public bool RotationOn = true;
    public float sensitivity = 1f;
    private Vector3 rotate;
    float x;
    public GameObject juno;
    public string direction;
    public string facing;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Display player's y rotation..
        //Debug.Log(juno.transform.eulerAngles.y);

        facing = juno.transform.eulerAngles.y.ToString();
        if (RotationOn == true)
        {
            x = Input.GetAxis("Mouse Y");
            rotate = new Vector3(x * sensitivity, 0);
            transform.eulerAngles = transform.eulerAngles - rotate;
        }
        else if (RotationOn == false)
        {
            
        }
    }

    public void CameraTurnOn()
    {

        if (RotationOn == true)
        {
            
        }
        else if (RotationOn == false)
        {
            //Lock to 0,90,180,or -90
            //Based on the 3d player's rotation...
            float angle = juno.transform.eulerAngles.y;
            juno.transform.rotation = Quaternion.Euler(0, 90, 0);

        }
    }
}
