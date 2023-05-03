using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractPositon : MonoBehaviour
{
    public string direction;
    public string facing;
    public GameObject InteractPoint;
    public GameObject juno;

    public void Update()
    {
        float angle = juno.transform.eulerAngles.y;
        if (angle >= 315 && angle < 360 || angle >= 0 && angle < 45 || Input.GetKeyDown(KeyCode.A))
        {
            InteractPoint.transform.rotation = Quaternion.Euler(0, 0, 0);
            direction = "SET TO WEST";
        }

        if (angle >= 45 && angle < 135 || Input.GetKeyDown(KeyCode.W))
        {
            InteractPoint.transform.rotation = Quaternion.Euler(0, 90, 0);
            direction = "SET TO NORTH";

        }
        if (angle >= 135 && angle < 225 || Input.GetKeyDown(KeyCode.D))
        {
            InteractPoint.transform.rotation = Quaternion.Euler(0, 180, 0);
            direction = "SET TO EAST";

        }
        if (angle >= 225 && angle < 315 || Input.GetKeyDown(KeyCode.S))
        {
            InteractPoint.transform.rotation = Quaternion.Euler(0, 270, 0);
            direction = "SET TO SOUTH";

        }
    }
    
}
