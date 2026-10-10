using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     for(int e = 22; e <= 100; e += 2)
        {
            UnityEngine.Debug.Log(e);
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
