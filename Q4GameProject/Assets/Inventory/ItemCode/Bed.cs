using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bed : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    public int AreYouSure = 0;
    public Text tip;

    public string InteractionPrompt => _prompt;

    public string IInteractionPrompt => throw new System.NotImplementedException();

    void IInteractable.Interact(Interactor interactor)
    {
        if (AreYouSure == 0)
        {
            AreYouSure++;
            tip.text = string.Format("Are you sure you want to sleep?");
            Invoke("ClearText", 1f);
            return;
        }
        if (AreYouSure == 1)
        {
            AreYouSure++;
            tip.text = string.Format("Are you REALLY sure?");
            Invoke("ClearText", 1f);
            return;
        }
        if (AreYouSure == 2)
        {
            PlayerPrefs.SetInt("BedUsed", 1);

            return;
        }

    }

    void ClearText()
    {
        tip.text = string.Format("");
    }
}
