using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        for(int a = 0; 1 < 10; a++)
        {
            Instantiate(prefab, new UnityEngine.Vector3(a * 3, 0, 0), UnityEngine.Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        } 

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
