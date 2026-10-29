using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "LTrigger")
        UnityEngine.Debug.Log("Enter LTrigger");
        if(other.gameObject.name == "RTrigger")
        UnityEngine.Debug.Log("Enter RTrigger");
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "LTrigger")
        UnityEngine.Debug.Log("Stay LTrigger");
        if(other.gameObject.name == "RTrigger")
        UnityEngine.Debug.Log("Stay RTrigger");
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "LTrigger")
        UnityEngine.Debug.Log("Exit LTrigger");
        if(other.gameObject.name == "RTrigger")
        UnityEngine.Debug.Log("Exit RTrigger");
    }
   
}
