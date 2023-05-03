using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public Dialogue dialogue;
    public bool convoStarted;
    public Text nameText;
    public Text dialogueText;

    //The very first sentence in a conversation or in this case
    //Juno talking to themself
    public string BaseMessage;

    //Use for initializing code
    void Start()
    {
        sentences = new Queue<string>();
        convoStarted = false;
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        nameText.text = dialogue.name;
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting conversation . . . " + dialogue.name);

        if (convoStarted == false)
        {
            foreach (string sentence in dialogue.sentences)
            {
                sentences.Enqueue(sentence);
            }
            convoStarted = true;

            DisplayNextSentence();
        }

        if (convoStarted == true)
        {
            //Debug.Log(sentences.Count);

            DisplayNextSentence();
        }
        
    }
    
    public void DisplayNextSentence()
    {
        
        if (sentences.Count == 0)
        {
            Debug.Log("End of conversation.");
            gameObject.SetActive(false);
            EndDialogue();
        }
        else
        {   
            string sentence = sentences.Dequeue();
            Debug.Log(sentence);
            dialogueText.text = sentence;
            StopAllCoroutines();
            StartCoroutine(TypeSentence(sentence));
        }
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        dialogueText.text = BaseMessage;
        convoStarted = false;
    }

}
