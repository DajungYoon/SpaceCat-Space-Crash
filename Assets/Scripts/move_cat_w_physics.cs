using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_cat_w_physics : MonoBehaviour
{

    public float moveForce = 3650.0f;

    public float maxSpeed = 3.0f;

    private int direction = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = -1;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = 1;
        }
        else
        {
            direction = 0;
        }

    }

    void FixedUpdate()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        if (direction * rb.velocity.x < maxSpeed) // if we don't exceed the max speed
        {
            rb.AddForce(Vector2.right * direction * moveForce); // add force to the cat
        }

        if (Mathf.Abs(rb.velocity.x) > maxSpeed) // if for some reason we have gone over our max speed
        {
            rb.velocity = new Vector2(Mathf.Sign(rb.velocity.x) * maxSpeed, rb.velocity.y); // set current speed to max speed
        }
    }
}
