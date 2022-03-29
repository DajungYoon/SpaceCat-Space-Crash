using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidVertical : MonoBehaviour {

    [SerializeField]
    private float amplitude = 0.5f;
    public float extraHeight = 0.5f;


    public AudioSource loseLife; 

    void Start () {
        loseLife = GetComponent<AudioSource> ();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        SpaceCat cat = collision.gameObject.GetComponent<SpaceCat>();

        if (cat != null) // if the cat is touching asteriod 
        {
            loseLife.Play ();
            // decrase the number of hearts 
            HeartSystem.num_hearts += -1;

            StartCoroutine ("GetInvulnerable");
        }
    }

    IEnumerator GetInvulnerable ()
	{
		Physics2D.IgnoreLayerCollision (6, 7, true);
		yield return new WaitForSeconds (1.5f);
		Physics2D.IgnoreLayerCollision (6, 7, false);
	}

    void Update()
    {
       // asteroids float up and down
        float x = transform.position.x;
        float y = Mathf.Sin(Time.time) * amplitude + extraHeight;
        float z = transform.position.z;
        transform.position = new Vector3(x, y, z); 
    }
}
