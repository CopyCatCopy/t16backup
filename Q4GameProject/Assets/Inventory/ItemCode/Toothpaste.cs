using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toothpaste : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;

    public string IInteractionPrompt => throw new System.NotImplementedException();

    void IInteractable.Interact(Interactor interactor)
    {
        Debug.Log("Take Toothpaste!");
        this.gameObject.SetActive(false);
        PlayerPrefs.SetInt("ToothpasteTaken", 1);
        return;
    }
}
