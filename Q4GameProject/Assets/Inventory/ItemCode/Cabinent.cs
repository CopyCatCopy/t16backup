using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cabinent : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    public int MiniGameChange;
    public int Complete = 0;

    public string IInteractionPrompt => throw new System.NotImplementedException();

    void IInteractable.Interact(Interactor interactor)
    {
        Complete = PlayerPrefs.GetInt("EatFood");
           if( Complete == 0)
        {
            PlayerPrefs.SetInt("FoodGameFinished", 0);
            PlayerPrefs.SetInt("FoodMiniGame", 1);
            PlayerPrefs.SetInt("MGameOn", 0);


            Cursor.lockState = CursorLockMode.None;
            Debug.Log(PlayerPrefs.GetInt("FoodMiniGame"));
            Debug.Log(PlayerPrefs.GetInt("MGameOn"));
        }
            


    }

    public void Off()
    {
        PlayerPrefs.SetInt("MiniGameChange", 0);
        PlayerPrefs.SetInt("FoodMiniGame", 0);
    }
}
