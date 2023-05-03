using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    public GameObject Door1;
    public bool locked = true;
    public int HasKey = 0;
    public bool Openned = false;


    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;

    public string IInteractionPrompt => throw new System.NotImplementedException();

    void IInteractable.Interact(Interactor interactor)
    {
        if (locked == true)
        {
            HasKey = PlayerPrefs.GetInt("HasKey");
            if (HasKey == 1)
            {
                locked = false;
                if (Openned == false)
                {
                    Debug.Log("Opening door!");
                    Door1.transform.rotation = Quaternion.Euler(0, 120, 0);
                    Door1.transform.position = new Vector3(18.5f, 0, 9.59f);
                    Debug.Log(transform.position);
                    Openned = true;
                    return;
                }
                else if (Openned == true)
                {
                    Debug.Log("Closing door!");
                    transform.rotation = Quaternion.Euler(0, 180, 0);
                    transform.position = new Vector3(19.8f, 0, 7.61f);
                    Openned = false;
                    return;
                }
            }
        }
        else if (locked == false)
        {
            if (Openned == false)
            {
                Debug.Log("Opening door!");
                Door1.transform.rotation = Quaternion.Euler(0, 120, 0);
                Door1.transform.position = new Vector3(18.5f, 0, 9.59f);
                Debug.Log(transform.position);
                Openned = true;
                return;
            }
            else if (Openned == true)
            {
                Debug.Log("Closing door!");
                transform.rotation = Quaternion.Euler(0, 0, 0);
                transform.position = new Vector3(19.8f, 0, 7.61f);
                Openned = false;
                return;
            }
        }

    }
}
