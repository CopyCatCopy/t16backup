using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sink : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    public int HasToothpaste = 0;
    public Text tip;

    public string InteractionPrompt => _prompt;

    public string IInteractionPrompt => throw new System.NotImplementedException();

    void IInteractable.Interact(Interactor interactor)
    {
        Debug.Log(PlayerPrefs.GetInt("HasToothpaste"));
        HasToothpaste = PlayerPrefs.GetInt("HasToothpaste");
        Debug.Log(HasToothpaste);
        if (HasToothpaste == 1)
        {
            PlayerPrefs.SetInt("MiniGameChange", 1);
            PlayerPrefs.SetInt("SinkMiniGame", 1);
            PlayerPrefs.SetInt("MGameOn", 0);
            Debug.Log("Start Mini-Game!");
            Cursor.lockState = CursorLockMode.None;
            PlayerPrefs.SetInt("HasToothpaste", 0);
            return;
        }
        else
        {
            tip.text = string.Format("Toothpaste needed!");
            Invoke("ClearText", 1f);
        }
    }

    void ClearText()
    {
        tip.text = string.Format("");
    }

}
