using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bacteria : MonoBehaviour
{
    public int health;
    public GameObject bacteria;
    public ParticleSystem hit;
    public Animator anim;
    public BacteriaController bc;
    public AudioSource hitsound;
    public AudioSource clean;
    public GameObject sparkle;

    // Start is called before the first frame update
    void Start()
    {
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        hit.Play();
        if (health != 0)
        {
            hitsound.Play();
            health--;
            anim.SetBool("hit", true);
            Invoke("Idle", 0.25f);
        }
        if (health == 0)
        {
            clean.Play();
            bc.counter++;
            sparkle.SetActive(true);
            bacteria.SetActive(false);

        }
    }

    private void OnMouseUp()
    {
        anim.SetBool("hit", false);
    }

    void Idle()
    {
        anim.SetBool("hit", false);
    }

}
