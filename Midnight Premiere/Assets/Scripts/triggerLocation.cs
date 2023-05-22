using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerLocation : MonoBehaviour
{
    public GameObject location, securecam;
    public string locationString;
    public Text locationText;
    
    private bool isTriggerEntered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isTriggerEntered)
        {
            isTriggerEntered = true;
            locationText.text = locationString;
            securecam.SetActive(true);
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && isTriggerEntered)
        {
            isTriggerEntered = false;
            //locationText.text = "";
            securecam.SetActive(false);
        }
    }
}
