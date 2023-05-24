using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickupCoin : MonoBehaviour
{
    public GameObject interact, monster;
    public AudioSource pickupSound;
    public bool interactable;
    public Text intText;
    public string intString;
    public static int coinsCollected;
    public lookAtSlender slenderScript;

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
                coinsCollected = coinsCollected + 1;
                collectionSystem.amountCollected = collectionSystem.amountCollected + 1; // from collectCoin.cs
                
                //These values change when a coin is picked up, making Slender more difficult.
                // slenderScript.drainRate = slenderScript.drainRate + 0.5f;
                // slenderScript.rechargeRate = slenderScript.rechargeRate - 0.5f;
                // slenderScript.healthDamage = slenderScript.healthDamage + 5f;
                // slenderScript.healthRechargeRate = slenderScript.healthRechargeRate - 0.5f;
                // slenderScript.audioIncreaseRate = slenderScript.audioIncreaseRate + 0.5f;
                // slenderScript.audioDecreaseRate = slenderScript.audioDecreaseRate - 0.5f;
                
                // if (monster.active == false)
                // {
                //     monster.SetActive(true);
                // }
                
                this.gameObject.SetActive(false);
                pickupSound.Play();
                interact.SetActive(false);
                interactable = false;
                
                // if (coinsCollected == 1)
                // {
                //     ambianceLayer1.Play();
                // }
                //
                // if (coinsCollected == 2)
                // {
                //     ambianceLayer2.Play();
                // }
                //
                // if (coinsCollected == 3)
                // {
                //     ambianceLayer3.Play();
                // }
                //
                // if (coinsCollected == 4)
                // {
                //     ambianceLayer4.Play();
                // }
                //
                // if (coinsCollected == 5)
                // {
                //     ambianceLayer5.Play();
                // }
                //
                // if (coinsCollected == 6)
                // {
                //     ambianceLayer6.Play();
                // }
                //
                // if (coinsCollected == 7)
                // {
                //     ambianceLayer7.Play();
                // }
                //
                // if (coinsCollected == 8)
                // {
                //     ambianceLayer8.Play();
                // }
                //
                // if (coinsCollected == 9)
                // {
                //     ambianceLayer9.Play();
                // }
                //
                // if (coinsCollected == 10)
                // {
                //     ambianceLayer10.Play();
                // }
            }
        }
    }
}
