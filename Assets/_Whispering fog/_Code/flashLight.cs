using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class flashLight : MonoBehaviour
{
    public Light light;
    public bool isOn = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Light>().enabled = isOn;
    }

    public void ToggleLight()
    {
        isOn = !isOn;
    }
}
