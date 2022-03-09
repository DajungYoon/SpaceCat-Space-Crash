using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineMovement : MonoBehaviour {

    [SerializeField]
	float moveSpeed = 5f;

	[SerializeField]
	float frequency = 20f;

	[SerializeField]
	float magnitude = 0.5f;

	bool goingRight = true;
	Vector3 pos;
    Vector3 localScale;

    void Start (){

        //starting position of the gameObject
        pos = transform.position;
		localScale = transform.localScale;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        SpaceCat cat = collision.gameObject.GetComponent<SpaceCat>();

        if (cat != null) // if the cat is touching asteriod 
        {
            // decrase the number of hearts 
            HeartSystem.num_hearts += -1;
        }
    }

    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    //SpaceCat cat = collision.gameObject.GetComponent<SpaceCat>();

    //    heart_count = cat.GetComponent<HeartSystem>();

    //    if (cat != null) // if the cat is touching asteriod 
    //    {

    //        Debug.Log("touch asteroid");
    //        heart_count.num_hearts += -1; // decrease heart count

    //    }
    //}

    // Update is called once per frame
    void Update()
    {

       CheckWhereToFace ();

		if (goingRight)
			MoveRight ();
		else
			MoveLeft ();
    }

    void CheckWhereToFace()
	{
        /*
        This function will check where the asteroid is heading
        */

        //if the position heading to the right side of the screen
		if (pos.x < -7f)
        //then set the boolean value to true
			goingRight = true;
		
        //if the position is heading to the left side of the screen
		else if (pos.x > 7f)
        //then set the boolean value to false
			goingRight = false;

        
        //when the object is going right, make the sprite go to the direction it is told
		if (((goingRight) && (localScale.x < 0)) || ((!goingRight) && (localScale.x > 0)))
			localScale.x *= -1;

		transform.localScale = localScale;

	}

    //using the sine function, make the object move to the right
    void MoveRight()
	{
		pos += transform.right * Time.deltaTime * moveSpeed;
		transform.position = pos + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
	}

    //using the sine function, make the object move to the right
	void MoveLeft()
	{
		pos -= transform.right * Time.deltaTime * moveSpeed;
		transform.position = pos + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
	}
}
