using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private Camera cameraComponent;
    // Start is called before the first frame update
    void Start()
    {
       cameraComponent = GetComponent<Camera>();
       cameraComponent.fieldOfView = 100f; 
    }

    // Update is called once per frame
    void Update()
    {
       float mouseXvalue = Input.GetAxis("Mouse X");
       float mouseYvalue = Input.GetAxis("Mouse Y");

       if(mouseXvalue != 0)
        {
            transform.Translate(mouseXvalue * 1f, 0f, 0f);
            UnityEngine.Debug.Log("mouse X movement" + mouseXvalue);
        } 
        if(mouseYvalue != 0)
        {
            transform.Translate(0f, mouseYvalue * 1f, 0f);
            UnityEngine.Debug.Log("mouse Y movement" + mouseYvalue);
        } 
    }
}
