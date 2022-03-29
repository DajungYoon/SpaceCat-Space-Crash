using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialPiece : MonoBehaviour
{
    private float amplitudes = .5f;
    public float extraHeights = 3.25f;

    public AudioSource collectPuzzles; 

    void Start () {
        collectPuzzles = GetComponent<AudioSource> ();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        SpaceCat cats = collision.gameObject.GetComponent<SpaceCat>();

        // if the cat is touching the puzzle piece 
        if (cats != null)
        {
            //play the audio source
            collectPuzzles.Play ();

            // the puzzle piece will disappear
            gameObject.SetActive(false);

           
        }
    }

    // Update is called once per frame
    void Update()
    {
        // piece floats up and down
        float x = transform.position.x;
        float y = Mathf.Sin(Time.time) * amplitudes + extraHeights;
        float z = transform.position.z;
        transform.position = new Vector3(x, y, z);
    }
}

