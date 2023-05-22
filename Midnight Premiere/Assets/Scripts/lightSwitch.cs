using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lightSwitch : MonoBehaviour
{
    public GameObject interact, light;
    public bool toggle = true, interactable;
    public Renderer lightBulb;
    public Material offLight, onLight;
    public AudioSource lightSwitchSound;
    public Animator switchAnim;
    public Text intText;
    public string intString;
    
    private void OnTriggerStay(Collider other)
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
                toggle = !toggle;
                //lightSwitchSound.Play();
                switchAnim.ResetTrigger("press");
                switchAnim.SetTrigger("press");
            }
        }

        if (toggle == false)
        {
            light.SetActive(false);
            lightBulb.material = offLight;
        }

        if (toggle == true)
        {
            light.SetActive(true);
            lightBulb.material = onLight;
        }
    }
}
