using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class safeCode : MonoBehaviour
{
    public bool interactable, toggle;
    public GameObject interact, noteimage, notetext, codeimage, codetext;
    public AudioSource pickupSound;
    public string intString;
    public string noteString;
    public Text intText;
    public Text noteText;
    public float noteTime;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if (toggle == false)
            {
                interact.SetActive(true);
                interactable = true;
                intText.text = intString;
            }
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
                pickupSound.Play();
                noteText.text = noteString;
                noteimage.SetActive(true);
                notetext.SetActive(true);
                interact.SetActive(false);
                StartCoroutine(disableDialogue());
                toggle = true;
                interactable = false;
                codeimage.SetActive(true);
                codetext.SetActive(true);
            }
        }
    }

    IEnumerator disableDialogue()
    {
        yield return new WaitForSeconds(noteTime);
        noteimage.SetActive(false);
        notetext.SetActive(false);
    }
}