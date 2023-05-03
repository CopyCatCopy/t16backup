using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerText : MonoBehaviour
{
    public GameObject obj;
    public GameObject empty;
    public AudioClip Noises;

    // Start is called before the first frame update
    void Start()
    {
        obj.SetActive(false);
        empty.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            obj.SetActive(true);

        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        AudioSource.PlayClipAtPoint(Noises, transform.position);
        empty.SetActive(false);
    }

}
