using System.Collections;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    [SerializeField, TextArea(5, 7)] private string[] dialogueLines;
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField] private GameObject buttonNext; 
    [SerializeField] private GameObject buttonChangeScene;

    private float typingTime = 0.008f;
    private int lineIndex;

    void Start()
    {
       
        buttonChangeScene.SetActive(false); 
        buttonNext.SetActive(false); 
        dialoguePanel.SetActive(true); 

        
        StartCoroutine(ShowLine());
    }

    public void NextDialogueLine()
    {
        lineIndex++;
        if (lineIndex < dialogueLines.Length)
        {
            StartCoroutine(ShowLine());
        }
        else
        {
            EndDialogue();
        }
    }

    private IEnumerator ShowLine()
    {
        dialogueText.text = string.Empty;
        buttonNext.SetActive(false); 

        foreach (char ch in dialogueLines[lineIndex])
        {
            dialogueText.text += ch;
            yield return new WaitForSeconds(typingTime);
        }

        
        if (lineIndex < dialogueLines.Length - 1)
        {
            buttonNext.SetActive(true);
        }
        else
        {
            
            buttonNext.SetActive(false);
            buttonChangeScene.SetActive(true);
        }
    }

    private void EndDialogue()
    {
        
        buttonNext.SetActive(false); 
        buttonChangeScene.SetActive(true);
    }

    
}
