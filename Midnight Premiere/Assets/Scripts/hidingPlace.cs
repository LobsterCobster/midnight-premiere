using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class hidingPlace : MonoBehaviour
{
    public GameObject interact;
    public GameObject stopHideText;
    public AudioSource hidingSound;
    public GameObject normalPlayer, hidingPlayer;
    public enemyMonsterAIraycast monsterScript;
    public Transform monsterTransform;
    bool interactable, hiding;
    public Text intText;
    public string intString;
    public float loseDistance;
    public GameObject walkFootsteps, runFootsteps; // so i can mute them when hiding
    
    void Start()
    {
        interactable = false;
        hiding = false;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            //hideText.SetActive(true);
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
        if(interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                hidingSound.Play();
                interact.SetActive(false);
                interactable = false;
                intText.text = "";
                hidingPlayer.SetActive(true);
                float distance = Vector3.Distance(monsterTransform.position, normalPlayer.transform.position);
                if(distance > loseDistance)
                {
                    if(monsterScript.chasing == true)
                    {
                        monsterScript.StopChasingPlayer();
                    }
                }
                stopHideText.SetActive(true);
                hiding = true;
                normalPlayer.SetActive(false);
            }
        }
        
        if(hiding == true)
        {
            interact.SetActive(false);
            walkFootsteps.SetActive(false);
            runFootsteps.SetActive(false);
            
            if (Input.GetKeyDown(KeyCode.Q))
            {
                interact.SetActive(true);
                interactable = true;
                intText.text = intString;
                stopHideText.SetActive(false);
                normalPlayer.SetActive(true);
                hidingPlayer.SetActive(false);
                hiding = false;
                walkFootsteps.SetActive(true);
                runFootsteps.SetActive(true);
            }
        }
    }
}