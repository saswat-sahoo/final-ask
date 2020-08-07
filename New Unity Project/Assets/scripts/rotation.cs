using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class rotation : MonoBehaviour
{
   
        private Vector3 _mouseReference;
    private Vector3 _mouseOffset;
    private Vector3 _rotation;
    public bool _isRotating;
    public Rigidbody rb;
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        _rotation = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("t")) {
            _isRotating = true; 
        }

        if (Input.GetKey("y")) {
            _isRotating = false; 
        }




        {
            if (_isRotating == true)
            {
               


                {
                    if (Input.GetKey("right"))
                    {
                        rb.angularVelocity = rb.transform.up * (speed * 5) * Time.deltaTime;

                    }

                    else if (Input.GetKey("left"))
                    {
                        rb.angularVelocity = rb.transform.up * (-speed * 5) * Time.deltaTime;
                    }

                    else rb.angularVelocity = rb.transform.up * 0;
                }


                {
                    if (Input.GetKey("up"))
                    {
                        rb.angularVelocity = rb.transform.forward * (speed * 5) * Time.deltaTime;

                    }

                    else if (Input.GetKey("down"))
                    {
                        rb.angularVelocity = rb.transform.forward * (-speed * 5) * Time.deltaTime;
                    }

                   
                }
            }
        }

       
    }

   
}
