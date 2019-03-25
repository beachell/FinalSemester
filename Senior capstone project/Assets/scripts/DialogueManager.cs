using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {
}

/*
    public Queue <string> sentances;
    public Text dialogueText; 

    void Start () {
        sentances = new Queue<string>();

	}

    public void StartDialogue(Dialog dialogue)
    {
        sentances.Clear();
        foreach (string sentence in dialogue.sentances)
        {
            //this is where it will determine which sentance will be pulled up.
            sentances.Enqueue(sentances);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentances.Count == 0)
        {
            EndDialogue();
        }
        string sentence = sentances.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        dialogueText.text = sentence;
    }

    IEnumerator TypeSentence(string sentances)
    {
        dialogueText.text = "";
        foreach(char letter in sentances.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    private void EndDialogue()
    {
     
    }
}
*/