using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdControlScript : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 up;
    public float speed;
    public Animator animator;
    
    void Start()
    {
        up = transform.up;
        speed = 0.05f;
       // animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (GameController.gameController.GetGameState()) {
            Vector2 position = transform.position;
            position.x += speed;
            transform.position = position;
        }
        Touch[] dizi = Input.touches;
        
        if (Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButtonDown(0)||dizi.Length>0) {
            //animator.SetTrigger("flyTrigger");
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().angularVelocity =0;
            GetComponent<Rigidbody2D>().AddForce(up * 300);
            dizi = new Touch[0];
           
        }
        

    }
    
}
