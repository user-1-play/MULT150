using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    Light lightComponent;
    // Start is called before the first frame update
    void Start()
    {
       lightComponent = GetComponent<Light>(); 
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown(KeyCode.L) == true)
        {
            if (lightComponent.enabled == true)
            {
                lightComponent.enabled = false;
                UnityEngine.Debug.Log("Light off");
            }
            else
            {
                lightComponent.enabled = true;
                UnityEngine.Debug.Log("Light on");
            }
        }
    }
}
