using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleCount : MonoBehaviour
{

    public static int num_pieces = 0;

    // Update is called once per frame
    void Update()
    {
        // if the number of puzzle pieces == 6
            // we change the scene to the puzzle solving scene

        if (num_pieces == 6) {
            
            SceneManager.LoadScene("puzzle");
            
        }
    }
}
