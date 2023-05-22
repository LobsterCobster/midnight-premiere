using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerDialogue : MonoBehaviour
{
    public GameObject dialogue;
    public AudioSource pickupSound;
    public string dialogueString;
    public Text dialogueText;
    public float dialogueTime = 1f;

    private Coroutine revealCoroutine;
    private bool isTriggerEntered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isTriggerEntered)
        {
            isTriggerEntered = true;
            pickupSound.Play();
            dialogue.SetActive(true);
            StopCoroutine("disableDialogue");
            StartRevealDialogue();
            StartCoroutine("disableDialogue");
        }
    }

    private void StartRevealDialogue()
    {
        // Stop any existing reveal coroutine
        if (revealCoroutine != null)
            StopCoroutine(revealCoroutine);

        // Reset the dialogue
        //dialogueText.text = string.Empty;
        
        // Set the dialogue to the string
        dialogueText.text = dialogueString;
        
        // Make the text visible
        dialogueText.enabled = true;

        // Start the scrolling coroutine
        //revealCoroutine = StartCoroutine(RevealDialogue());
    }

    private IEnumerator RevealDialogue()
    {
        string originalDialogue = dialogueText.text;
        string revealedDialogue = string.Empty;

        for (int i = 0; i < originalDialogue.Length; i++)
        {
            revealedDialogue += originalDialogue[i];
            dialogueText.text = revealedDialogue;

            yield return new WaitForSeconds(dialogueTime);
        }
    }

    private IEnumerator disableDialogue()
    {
        yield return new WaitForSeconds(2.0f);
        dialogue.SetActive(false);
    }
}
