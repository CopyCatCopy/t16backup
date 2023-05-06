using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alarm : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    public int HasBattery = 0;
    public string InteractionPrompt => _prompt;
    public int MiniGameChange;
    public Text tip;

    public string IInteractionPrompt => throw new System.NotImplementedException();

    void IInteractable.Interact(Interactor interactor)
    {
        HasBattery = PlayerPrefs.GetInt("HasBattery");
        Debug.Log(PlayerPrefs.GetInt("HasBattery"));
        if (HasBattery == 1)
        {
            PlayerPrefs.SetInt("MiniGameChange", 1);
            PlayerPrefs.SetInt("AlarmMiniGame", 1);
            PlayerPrefs.SetInt("MGameOn", 0);

            PlayerPrefs.SetInt("HasBattery", 0);
            Cursor.lockState = CursorLockMode.None;
            Debug.Log(PlayerPrefs.GetInt("AlarmMiniGame"));
            Debug.Log(PlayerPrefs.GetInt("MGameOn"));
        }
        else
        {
            tip.text = string.Format("Item needed!");
            Invoke("ClearText", 1f);
        }

        

    } 

    void ClearText()
        {
            tip.text = string.Format("");
        }
   
}
