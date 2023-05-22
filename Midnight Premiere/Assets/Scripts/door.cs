using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class door : MonoBehaviour
{
    //public GameObject intText, key, lockedText;
    public GameObject interact, key, dialogue;
    public AudioSource pickupSound;
    public bool interactable, toggle;
    public Animator doorAnim;
    public Text dialogueText;
    public string dialogueString;
    public string intString;
    public Text intText;
    public float dialogueTime = 1f;
    
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            interact.SetActive(true);
            interactable = true;
            intText.text = intString;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            interact.SetActive(false);
            interactable = false;
        }
    }

    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (key.active == false)
                {
                    toggle = !toggle;
                    if (toggle == true)
                    {
                        doorAnim.ResetTrigger("close");
                        doorAnim.SetTrigger("open");
                    }

                    if (toggle == false)
                    {
                        doorAnim.ResetTrigger("open");
                        doorAnim.SetTrigger("close");
                    }
                
                    interact.SetActive(false);
                    interactable = false;    
                }

                if (key.active == true)
                {
                    dialogue.SetActive(true);
                    pickupSound.Play();
                    dialogueText.text = dialogueString;
                    StopCoroutine("disableDialogue");
                    StartCoroutine("disableDialogue");
                }
                {
                    
                }
            }
        }
    }

    IEnumerator disableDialogue()
    {
        yield return new WaitForSeconds(2.0f);
        dialogue.SetActive(false);
    }
}
