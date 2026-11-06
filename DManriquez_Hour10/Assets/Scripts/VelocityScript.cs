using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class VelocityScript : MonoBehaviour
{
    public float startSpeed = 50f;
    // Start is called before the first frame update
    void Start()
    {
       Rigidbody rigidBody = GetComponent<Rigidbody>();
       rigidBody.velocity = new UnityEngine.Vector3(startSpeed, 0, startSpeed); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
