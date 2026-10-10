using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     for(int day = 1; day <= 31; day++)
        {
            if (day == 9)
            {
                UnityEngine.Debug.Log("Its my birthday!");
            }
            else
            {
                UnityEngine.Debug.Log(day);
            }
        } 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
