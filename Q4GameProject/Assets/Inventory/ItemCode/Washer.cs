using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Washer : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    public int HasSocks = 0;
    public string InteractionPrompt => _prompt;

    public string IInteractionPrompt => throw new System.NotImplementedException();

    void IInteractable.Interact(Interactor interactor)
    {
        HasSocks = PlayerPrefs.GetInt("HasSocks");
        Debug.Log(PlayerPrefs.GetInt("HasBattery"));
        if (HasSocks == 1)
        {
            PlayerPrefs.SetInt("LaundryMiniGameComplete", 1);

            PlayerPrefs.SetInt("HasSocks", 0);
        }


    }


}
