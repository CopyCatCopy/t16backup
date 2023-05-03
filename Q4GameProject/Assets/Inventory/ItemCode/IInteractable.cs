using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
   public string IInteractionPrompt { get; }

    public void Interact(Interactor interactor);
}
