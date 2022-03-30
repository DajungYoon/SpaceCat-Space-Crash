using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSound : MonoBehaviour
{

    public AudioSource collectPuzzle;
    // Start is called before the first frame update
    void Start()
    {
        collectPuzzle = GetComponent<AudioSource>();
    }

    public void PlayPuzzle()
    {
        collectPuzzle.Play();
    }
}
