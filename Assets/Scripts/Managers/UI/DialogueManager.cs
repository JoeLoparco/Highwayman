/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance;

    public TextMeshProUGUI charcaterName;
    public TextMeshProUGUI dialogueArea;
    private Queue<DialogueLine> lines;
    public bool isDialogueActive = false;
    public float typingSpeed = 0.2f;

    public Animator animator;

    void start(){
        if(Instance == null)
            Instance = this;
    }

    public void StartDialogue(DialogueManager dialogue)
    {
        isDialogueActive = true;
        animator.Play("show");
        lines.clear();
        foreach (DialogueLine dialogueLine in dialogue.dialogueLines){
            lines.Enqueue(dialogueLine);
        }
        DisplayNextDialogueLine();
    } 

    public void DisplayNextDialogue()
    {
        if(lines.Count == 0)
        {
            EndDialogue();
            return;
        }

        DialogueLine = currentLine = lines.Dequeue();
        characterName = currentLine.character.name;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(CurrentLine));
    }

    IEnumerator TypeSentence(DialogueLine dialogueLine)
    {
        dialogueArea.text = "";
        foreach(char letter in dialogueLine.line.ToCharArray()){
            dialogueArea.text += letter;
            yield return new WaitForSecond(typingSpeed);
        }
    }

    void EndDialogue()
    {
        isDialogueActive = false;
        animator.Play("hide");
    }

}
*/
