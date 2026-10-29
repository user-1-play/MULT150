using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    int count = 0;

     void OnCollisionEnter(Collision other)
    {
       if(other.gameObject.name == "Sphere")
        {
        count++;
        UnityEngine.Debug.Log("Bounce count:" + count); 
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
