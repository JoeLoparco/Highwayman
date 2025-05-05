using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageLadyController : MonoBehaviour
{

    GameObject dialogue;

    Dialogue_stage_lady dialogueScript;
    void Awake() {
        dialogue = GameObject.Find("DialogueBox");

        if (dialogue != null){
            dialogueScript = dialogue.GetComponent<Dialogue_stage_lady>();
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
