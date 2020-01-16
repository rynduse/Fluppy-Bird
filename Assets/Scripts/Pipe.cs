using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed = 2;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // despawn coin if it goes past the left edge of the screen
        if (transform.position.x < -15)
        {
            Destroy(gameObject);
        }
        else
        {

            // ensure coin moves at the same rate as the skyscrapers do
            transform.Translate(-speed * Time.deltaTime, 0, 0, Space.World);
        }

       
    }

    
}
