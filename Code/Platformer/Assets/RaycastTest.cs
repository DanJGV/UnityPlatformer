using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray r = new Ray(transform.position, Vector3.down);
        Debug.DrawLine(r.origin, r.direction, Color.red, 100.0f);
        Debug.Log("Updating");
    }
}
