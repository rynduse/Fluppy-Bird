using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        for(var i=0; i< Input.touchCount; i++)
        {
            if(Input.GetTouch(i).phase == TouchPhase.Began)
            {
                rb.AddForce(Vector3.up * 200);
            }
        }
    }
}
