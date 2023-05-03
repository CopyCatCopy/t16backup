using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    public int AreYouSure = 0;

    public string InteractionPrompt => _prompt;

    public string IInteractionPrompt => throw new System.NotImplementedException();

    void IInteractable.Interact(Interactor interactor)
    {
        if (AreYouSure == 0)
        {
            AreYouSure++;
            return;
        }
        if (AreYouSure == 1)
        {
            AreYouSure++;
            return;
        }
        if (AreYouSure == 2)
        {
            PlayerPrefs.SetInt("BedUsed", 1);

            return;
        }

    }
}
