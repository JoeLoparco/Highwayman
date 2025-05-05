using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NurseController : MonoBehaviour
{
  
    GameObject dialogue;

    Dialogue_nurse dialogueScript;
    void Awake() {
        dialogue = GameObject.Find("DialogueBox");

        if (dialogue != null){
            dialogueScript = dialogue.GetComponent<Dialogue_nurse>();
        }
    }

    void OnMouseDown()
    {
        // Call the method on the target script
        if (dialogueScript != null)
        {
            dialogueScript.StartDialogue();
        }
    }
}
