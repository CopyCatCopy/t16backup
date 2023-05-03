using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public float Xposition, Yposition, Zposition;

    public void Save()
    {
        Xposition = transform.position.x;
        Yposition = transform.position.y;
        Zposition = transform.position.z;



        PlayerPrefs.SetFloat("X", Xposition);
        PlayerPrefs.SetFloat("Y", Yposition);
        PlayerPrefs.SetFloat("Z", Zposition);
    }

    public void Load()
    {
        PlayerPrefs.GetFloat("X");
        PlayerPrefs.GetFloat("Y");
        PlayerPrefs.GetFloat("Z");

        Vector3 LoadPosition = new Vector3(Xposition, Yposition, Zposition);
        transform.position = LoadPosition;
    }
}
