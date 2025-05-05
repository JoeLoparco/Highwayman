using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSmithController : MonoBehaviour
{

    GameObject dialogue;

    Dialogue_gun_smith dialogueScript;
    void Awake() {
        dialogue = GameObject.Find("DialogueBox");

        if (dialogue != null){
            dialogueScript = dialogue.GetComponent<Dialogue_gun_smith>();
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
