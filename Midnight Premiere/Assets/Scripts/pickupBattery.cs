using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickupBattery : MonoBehaviour
{
    public GameObject interact;
    public AudioSource pickupSound;
    public string intString;
    public Text intText;
    public bool interactable;
    public flashlight flashlightScript;
    
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
                pickupSound.Play();
                flashlightScript.batteryLife = 100f;
                interact.SetActive(false);
                this.gameObject.SetActive(false);
                interactable = false;
            }
        }
    }
}
