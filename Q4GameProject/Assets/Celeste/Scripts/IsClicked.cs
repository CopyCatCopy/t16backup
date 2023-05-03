using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsClicked : MonoBehaviour
{
    public bool isPoked;
    private SpriteRenderer sr;
    private Animator anim;
    public GameObject obj;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        anim.SetBool("isPoked", false);
        obj.SetActive(false);
    }

    private void OnMouseDown()
    {
        anim.SetBool("isPoked", true);
        obj.SetActive(true);
    }
}
