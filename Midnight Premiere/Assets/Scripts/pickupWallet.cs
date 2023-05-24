using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickupWallet : MonoBehaviour
{
    public GameObject interact;
    public AudioSource pickupSound;
    public bool interactable;
    public Text intText;
    public string intString;
    public static int coinsCollected;

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

    void Start()
    {
        coinsCollected = 0;
    }

    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //coinsCollected = coinsCollected + 500;
                collectionSystem.amountCollected = collectionSystem.amountCollected + 500; // from collectCoin.cs
                
                this.gameObject.SetActive(false);
                pickupSound.Play();
                interact.SetActive(false);
                interactable = false;
            }
        }
    }
}
