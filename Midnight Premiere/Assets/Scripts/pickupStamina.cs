using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickupStamina : MonoBehaviour
{
    public GameObject interact;
    public AudioSource pickupSound;
    public string intString;
    public Text intText;
    public bool interactable;
    public SC_FPSController staminaScript;
    
    // trying to highlight interactable objects
    public Color highlightColor;
    private Color originalColor;
    private Renderer objectRenderer;

    // trying to highlight interactable objects
    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        originalColor = objectRenderer.material.color;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            interact.SetActive(true);
            interactable = true;
            intText.text = intString;
            // trying to highlight interactable objects
            //objectRenderer.material.color = highlightColor;
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            interact.SetActive(false);
            interactable = false;
            // trying to highlight interactable objects
            //objectRenderer.material.color = originalColor;
        }
    }
    
    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                pickupSound.Play();
                staminaScript.staminaLife = 100f;
                interact.SetActive(false);
                this.gameObject.SetActive(false);
                interactable = false;
            }
        }
    }
}
