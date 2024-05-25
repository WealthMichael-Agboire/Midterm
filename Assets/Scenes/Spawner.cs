using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
 public float spawntime;
 float counter;  
 public GameObject obstacle; 
 public float range;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter -= Time.deltaTime;
        if (counter < 0)
        {
            counter = spawntime;
            Vector2 pos = new Vector2(transform.position.x, Random.RandomRange(-range, range));
            Instantiate(obstacle, pos, obstacle.transform.rotation);
        }
    }
}
