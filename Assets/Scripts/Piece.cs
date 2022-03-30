using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    private float amplitude = 0.2f;
    public float extraHeight = 3.75f;
    private const float _dyingWaitTime = 0.05f;

    public AudioSource collectPuzzle; 

    void Start () {
        collectPuzzle = GetComponent<AudioSource>();
    }
    IEnumerator CollectAndDestroy(){
        //this function is used for the Coroutine used in collision

        //play the audio source
        collectPuzzle.Play ();

        //have a small delay before making the puzzle piece disappear
        yield return new WaitForSeconds(_dyingWaitTime);

        // the puzzle piece will disappear after playing the audio source
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
