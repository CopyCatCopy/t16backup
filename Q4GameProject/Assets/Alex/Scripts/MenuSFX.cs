using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSFX : MonoBehaviour
{

    public AudioSource select;
    public AudioClip hover;

    public void Select()
    {
        select.Play();
    }

    public void Hover()
    {
        select.PlayOneShot(hover);
    }
}
