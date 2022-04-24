using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    private float amplitude = 0.2f;
    public float extraHeight = 3.75f;
    private const float _dyingWaitTime = 0.02f;

    public AudioSource collectPuzzle;

    void Start()
    {
        gameObject.SetActive(true);
        collectPuzzle = GetComponent<AudioSource>();

    }

    IEnumerator CollectAndDestroy(){
        //this function is used for the Coroutine used in the collision
        
        //play the audio source
        collectPuzzle.Play();

        //this function will insert a small delay before making the puzzle piece disappear
        Physics2D.IgnoreLayerCollision(6,8,true);
        yield return new WaitForSeconds(_dyingWaitTime);
        Physics2D.IgnoreLayerCollision(6,8,false);

        //this line makes the puzzle piece disappear
        gameObject.SetActive(false);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        SpaceCat cat = collision.gameObject.GetComponent<SpaceCat>();

        // if the cat is touching the puzzle piece 
        if (cat != null)
        {
            // add another piece to the count
            PuzzleCount.num_pieces += 1;

            //calls the coroutine
            StartCoroutine(CollectAndDestroy());

            Debug.Log("number of pieces = " + PuzzleCount.num_pieces);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // piece floats up and down
        float x = transform.position.x;
        float y = Mathf.Sin(Time.time) * amplitude + extraHeight;
        float z = transform.position.z;
        transform.position = new Vector3(x, y, z);
    }

}
