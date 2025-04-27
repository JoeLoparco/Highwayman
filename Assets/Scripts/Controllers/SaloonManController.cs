using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaloonManController : MonoBehaviour
{

    GameObject dialogue;
    Dialogue dialogueScript;

    void Awake(){
        dialogue = GameObject.Find("DialogueBox");
        
        // If found, get the Dialogue component
        if (dialogue != null)
        {
            dialogueScript = dialogue.GetComponent<Dialogue>();
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
