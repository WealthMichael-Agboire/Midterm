using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Bird : MonoBehaviour
{
  public float speed;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        }
    }

    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.transform.tag == "obs" || other.transform.tag == "Floor")
        {
SceneManager.LoadScene(0);
        }
    }
}
