using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject obj;
    public float delayTime = 3f;

    void Start()
    {
        obj.SetActive(false);
    }

    private void OnMouseDown()
    {

        Invoke("ConvoStart", delayTime);
        
    }

    public void ConvoStart()
    {
        obj.SetActive(true);
    }
   
}
