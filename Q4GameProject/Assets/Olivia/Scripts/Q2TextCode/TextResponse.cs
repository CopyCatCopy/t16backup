using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResponseText : MonoBehaviour
{
    [SerializeField]
    GameObject Text;
    public void Txt()
    {
        Text.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        Text.SetActive(false);
    }






}
