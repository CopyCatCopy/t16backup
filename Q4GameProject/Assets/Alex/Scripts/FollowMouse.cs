using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public GameObject obj;
    float clickOffset = 0;
    public ParticleSystem foam;
    
    void Update()
    {
        obj.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y - 875f - clickOffset, Camera.main.nearClipPlane + 9f));

        if (Input.GetMouseButtonDown(0))
        {
            clickOffset = 50;
            foam.Play();
        }
        if (Input.GetMouseButtonUp(0))
        {
            clickOffset = 0;
        }
    }


}
