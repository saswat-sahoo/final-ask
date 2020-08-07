using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class col : MonoBehaviour

{
    public Rigidbody rb;
    public float speed = 10;
    void start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate() {

        if (Input.GetKey("m"))
        { 
           rb.angularVelocity = rb.transform.up * (speed * 5) * Time.deltaTime;
            
        }        
    }
}
