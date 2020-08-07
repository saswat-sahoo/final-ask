
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
   
    public Rigidbody rb;
    private Transform playerTranform;
    public float speed = 10;
    public GameObject enemy;
    public Image image;
    public Text text;
    public Image image1;
    public Text text1;
   




    // Start is called before the first frame update
    void Start()
    {
       
        rb = GetComponent<Rigidbody>();
        this.rb.useGravity = false;
        enemy = GameObject.FindGameObjectWithTag("enemy");
       
        {
            for (int i = 0; i < 150 ; i++)
            {
                SpawnDrop();
            }
        }

        image.enabled = false;
        text.enabled = false;
        image1.enabled = false;
        text1.enabled = false;
       
    }
    

   
    
    void FixedUpdate()
    {
        if (Input.GetKey("g")) { this.rb.useGravity = true;  }
        if (Input.GetKey("h")) { this.rb.useGravity = false;  }
        Debug.Log("" + gameObject.transform.eulerAngles);

       

        if (Input.GetKey("w"))
        {
            
            transform.position += (transform.right * (-speed ) * Time.deltaTime);

        }

        if (Input.GetKey("s"))
        {
            transform.position += (transform.right* (speed) * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {

            transform.position += (transform.forward * (-speed) * Time.deltaTime);

        }
        if (Input.GetKey("d"))
        {
            transform.position += (transform.forward * (speed) * Time.deltaTime);

        }

        
        
            if (Input.GetKey("up"))
            {

                rb.velocity = Vector3.zero;
                transform.position += (transform.up * (speed) * Time.deltaTime);
            }

            if (Input.GetKey("down"))
            {
                rb.velocity = Vector3.zero;

                transform.position += (transform.up * (-speed) * Time.deltaTime);

            }
        
      


        {
            if (Input.GetKey("right"))
            {
                rb.angularVelocity = rb.transform.up * (speed*5 ) * Time.deltaTime;
               
            }

            else if (Input.GetKey("left"))
            {
                rb.angularVelocity = rb.transform.up * (-speed*5) * Time.deltaTime;
            }

            else rb.angularVelocity = rb.transform.up * 0;
        }


        
       
       
        
        if (Input.GetKey("space"))
        {
            
            transform.rotation = Quaternion.Euler(0,90 , 0);
            
        }
        if (Input.GetKey("r"))
        {
            image.enabled = false;
            text.enabled = false;
            image1.enabled = false;
            
        }
       
    }



    void SpawnDrop()
    {


        Instantiate(enemy, new Vector3(Random.Range(-45.0f, 45.0f), Random.Range(-45.0f, 45.0f), Random.Range(-45.0f, 45.0f)), Quaternion.identity);

    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "enemy")
        {
            transform.position = new Vector3(-45, 48, -45);
            image.enabled = true;
            text.enabled = true;

        }
        if (collisionInfo.collider.tag == "goal")
        {
            image1.enabled = true;
            text1.enabled = true;

            
                Invoke ("Scene",1.5f);
            
        }
       
    }
   
    public void Scene()
    {
        SceneManager.LoadScene("final");
        
    }

}
