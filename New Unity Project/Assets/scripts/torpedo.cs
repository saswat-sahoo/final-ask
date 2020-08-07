using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

public class torpedo : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject missile;
    public GameObject currentMissile;
    public float speed = 20f;
    bool launched;

    // Start is called before the first frame update
    void Start()
    {
        Launch();

    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetButtonDown("Fire1"))
        {
            launched = true;
        }


    }


    void FixedUpdate()
    {
        if (launched)
            Launch();
    }
    





    private void Load()
    {

        GameObject missileInstance = Instantiate(missile, spawnPoint.position, spawnPoint.rotation);
        missileInstance.transform.parent = spawnPoint;
        currentMissile = missileInstance;
        Rigidbody rb = currentMissile.GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }
    private void Launch()
    {
        Rigidbody rb = currentMissile.GetComponent<Rigidbody>();
        currentMissile.transform.parent = null;
        rb.isKinematic = false;
        rb.AddForce(spawnPoint.right * (-speed), ForceMode.Impulse);
        launched = false;
        Invoke("Load", 2f);
    }
        
}



