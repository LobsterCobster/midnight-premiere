using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class laserSwitch : MonoBehaviour
{
    public Animator switchAnim;
    public GameObject lasers, interaction;
    public bool interactable, toggle;
    public Text intText;
    public string intString;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if (toggle == false)
            {
                interaction.SetActive(true);
                interactable = true;
                intText.text = intString;
            }
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
                switchAnim.SetTrigger("pull");
                lasers.SetActive(false);
                interaction.SetActive(false);
                toggle = true;
                interactable = false;
            }
        }
    }
}
