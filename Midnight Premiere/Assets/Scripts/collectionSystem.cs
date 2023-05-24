using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectionSystem : MonoBehaviour
{
    public static int amountCollected;
    //public Collider trigger;
    public int finalAmount;
    public Text collectionText;
    public GameObject triggerObj, triggerObj1, moneyText;
    
    void Start()
    {
        amountCollected = 0;
    }
    
    void Update()
    {
        if (amountCollected >= finalAmount)
        {
            triggerObj.SetActive(true);
            triggerObj1.SetActive(false);
            //collectionText.gameObject.SetActive(false); // added to resolve issue introduced with render change
            moneyText.SetActive(true);
            //trigger.enabled = true;
        }
        
        //collectionText.text = amountCollected + "/" + finalAmount;
        collectionText.text = amountCollected.ToString();
    }
}