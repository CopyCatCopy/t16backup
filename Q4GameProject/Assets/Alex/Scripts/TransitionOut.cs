using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionOut : MonoBehaviour
{
    public Transition t;
    // Start is called before the first frame update
    void Start()
    {
        t.Invoke("FadeIn", 4.5f);
    }
}
