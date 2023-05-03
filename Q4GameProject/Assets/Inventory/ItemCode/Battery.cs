using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;

    public string IInteractionPrompt => throw new System.NotImplementedException();

    void IInteractable.Interact(Interactor interactor)
    {
        Debug.Log("Take Battery!");
        this.gameObject.SetActive(false);
        PlayerPrefs.SetInt("BatteryTaken", 1);
        return;
    }
}


