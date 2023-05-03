using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{

    public GameObject juno;
    public GameObject JunoFront;
    public bool FrontOn;
    public bool SideOn;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void PlayerRotateLeft()
    //{
    //    juno.transform.rotation = juno.transform.rotation * Quaternion.Euler(0, -90, 0);
    //    //if (FrontOn == true) 
    //    //{ 
    //    //    JunoFront.SetActive(true);
    //    //    JunoBack.SetActive(false);
    //    //    JunoSide.SetActive(false);
    //    //}
    //    //else if (FrontOn == false)
    //    //{
    //    //    JunoFront.SetActive(false);
    //    //    JunoBack.SetActive(true);
    //    //    JunoSide.SetActive(true);
    //    //}
        
    //}

    //public void PlayerRotateRight()
    //{
    //    juno.transform.rotation = juno.transform.rotation * Quaternion.Euler(0, 90, 0);
    //    //if (SideOn == true)
    //    //{
    //    //    JunoFront.SetActive(false);
    //    //    JunoBack.SetActive(true);
    //    //    JunoSide.SetActive(true);
    //    //}
    //    //else if (SideOn == false)
    //    //{
    //    //    JunoFront.SetActive(true);
    //    //    JunoFront.SetActive(false);
    //    //    JunoSide.SetActive(false);
    //    //}
    //}
}
