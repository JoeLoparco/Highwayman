using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue_nurse : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    // Start is called before the first frame update
    public float textSpeed;
    private int index;
    
    public string[] lines_1 = new string[] 
    {
        "Nurse: Graaaaaa",
        "Nurse: Bang Bang."
    };
    void Start()
    {
        if (economy_manager.Instance.buildNurse == true){
            lines = lines_1;
        }
        gameObject.SetActive(false);  
        /*
        textComponent.text = string.Empty;
        StartDialogue();
        */
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    public void StartDialogue()
    {
        index = 0;
        gameObject.SetActive(true); 
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach(char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if(index < lines.Length -1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }else{
            gameObject.SetActive(false);  
        }
    }
}
