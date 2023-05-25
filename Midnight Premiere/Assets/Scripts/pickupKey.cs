using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickupKey : MonoBehaviour
{
    public GameObject interaction, key, keyimage;
    public AudioSource pickup;
    public bool interactable;
    public Text intText;
    public string intString;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            interaction.SetActive(true);
            interactable = true;
            intText.text = intString;
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            interaction.SetActive(false);
            interactable = false;
        }
    }
    
    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                interaction.SetActive(false);
                interactable = false;
                pickup.Play();
                key.SetActive(false);
                keyimage.SetActive(true);
            }
        }
    }
}
