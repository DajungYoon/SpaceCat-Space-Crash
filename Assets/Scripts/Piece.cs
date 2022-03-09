using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{

    private float amplitude = 0.2f;
    public float extraHeight = 3.75f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        SpaceCat cat = collision.gameObject.GetComponent<SpaceCat>();

        // if the cat is touching the puzzle piece 
        if (cat != null)
        {
            // the puzzle piece will disappear
            gameObject.SetActive(false);

            // add another piece to the count
            PuzzleCount.num_pieces += 1;

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
