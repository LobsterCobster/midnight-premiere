using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightBreaker : MonoBehaviour
{
    public GameObject lightObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Disable the light
            lightObject.SetActive(false);
            
            // Add any other effects or actions you want to happen when the light breaks.
        }
    }
}
