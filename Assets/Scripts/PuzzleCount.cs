using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleCount : MonoBehaviour
{
    public GameObject[] pieces;
    public static int num_pieces = 0;


    void Start()
    {
        (pieces[1].gameObject).GetComponent<Renderer>().enabled = false;
        (pieces[2].gameObject).GetComponent<Renderer>().enabled = false;
        (pieces[3].gameObject).GetComponent<Renderer>().enabled = false;
        (pieces[4].gameObject).GetComponent<Renderer>().enabled = false;
        (pieces[5].gameObject).GetComponent<Renderer>().enabled = false;
        (pieces[6].gameObject).GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // if the number of puzzle pieces == 6
        // we change the scene to the puzzle solving scene
        if (num_pieces == 1)
        {
            (pieces[0].gameObject).GetComponent<Renderer>().enabled = false;
            (pieces[1].gameObject).GetComponent<Renderer>().enabled = true;
        }

        if (num_pieces == 2)
        {
            (pieces[1].gameObject).GetComponent<Renderer>().enabled = false;
            (pieces[2].gameObject).GetComponent<Renderer>().enabled = true;
        }

        if (num_pieces == 3)
        {
            (pieces[2].gameObject).GetComponent<Renderer>().enabled = false;
            (pieces[3].gameObject).GetComponent<Renderer>().enabled = true;
        }

        if (num_pieces == 4)
        {
            (pieces[3].gameObject).GetComponent<Renderer>().enabled = false;
            (pieces[4].gameObject).GetComponent<Renderer>().enabled = true;
        }

        if (num_pieces == 5)
        {
            (pieces[4].gameObject).GetComponent<Renderer>().enabled = false;
            (pieces[5].gameObject).GetComponent<Renderer>().enabled = true;
        }
        if (num_pieces == 6)
        {
            (pieces[5].gameObject).GetComponent<Renderer>().enabled = false;
            (pieces[6].gameObject).GetComponent<Renderer>().enabled = true;
        }

    }
}
