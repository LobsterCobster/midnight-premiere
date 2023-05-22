using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayTimer : MonoBehaviour
{
    public float time;
    public Text timeElapsedText;

    void Update()
    {
        time += Time.deltaTime;
        UpdateUI();
    }

    private void UpdateUI()
    {
        // Time
        timeElapsedText.text = time.ToString("F2");
    }
}
