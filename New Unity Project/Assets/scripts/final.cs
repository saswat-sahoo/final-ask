using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class final : MonoBehaviour

{
    public Image image;
    public Image image1;
    public Text text;
    public Text text1;
    // Start is called before the first frame update
    void Start()
    {
        image.enabled = false;
        image1.enabled = false;
        text.enabled = false;
        text1.enabled = false;

    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "red")
        {
            image.enabled = true;
            text.enabled = true;
            // text.enabled = true;

            Invoke("Scene", 2.0f);

        }
        
    }
    void OnTriggerEnter(Collider other)
    {
        image1.enabled = true;
        text1.enabled = true;
    }
    public void Scene()
    {
        SceneManager.LoadScene("final");
    }
}
