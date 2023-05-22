using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightFlicker : MonoBehaviour
{
    public float minIntensity = 0.5f;
    public float maxIntensity = 1.5f;
    public float flickerSpeed = 0.1f;

    private Light flickeringLight;
    private float baseIntensity;

    private void Start()
    {
        flickeringLight = GetComponent<Light>();
        baseIntensity = flickeringLight.intensity;

        InvokeRepeating("Flicker", 0f, flickerSpeed);
    }

    private void Flicker()
    {
        float flickerIntensity = Random.Range(minIntensity, maxIntensity);
        flickeringLight.intensity = flickerIntensity * baseIntensity;
    }
}
