using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunoDoor : MonoBehaviour, IInteractable
{
    public GameObject Door;
    public int HasKey = 0;
    public bool Openned = false;


    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;

    public string IInteractionPrompt => throw new System.NotImplementedException();

    void IInteractable.Interact(Interactor interactor)
    {
        if (Openned == false)
        {
            Debug.Log("Opening door!");
            Door.transform.rotation = Quaternion.Euler(0, 295, 0);
            Door.transform.position = new Vector3(-2.6f, 0, -9.4f);
            Debug.Log(transform.position);
            Openned = true;
            return;
        }
        else if (Openned == true)
        {
            Debug.Log("Closing door!");
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.position = new Vector3(-4.16f, 0, -7.5f);
            Openned = false;
            return;
        }
    }

}
