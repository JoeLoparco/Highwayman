using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StableManController : MonoBehaviour
{
    GameObject dialogue;

    Dialogue_stable dialogueScript;
    void Awake() {
        dialogue = GameObject.Find("DialogueBox");

        if (dialogue != null){
            dialogueScript = dialogue.GetComponent<Dialogue_stable>();
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
