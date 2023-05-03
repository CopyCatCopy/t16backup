using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDirection : MonoBehaviour
{
    public GameObject Direction;
    public string CTag;


    // Update is called once per frame
    void Update()
    {
        

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            CTag = "Wall";
        }
        else
        {
            CTag = "";
        }
    }
}
