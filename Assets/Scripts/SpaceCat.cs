using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceCat : MonoBehaviour
{
    public float speed = 5.5f;

    private Animator anim;
    private int runRight = 1;
    private int runLeft = -1;

    void Start()
    {
        anim = GetComponent<Animator>();     
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            anim.SetInteger("RunningState", runRight); // set anim. direction
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            anim.SetInteger("RunningState", runLeft); // set anim. direction
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;
        

        //changing to the next scene to build the puzzle
        if (PuzzleCount.num_pieces == 6)
        {
            Debug.Log("All puzzles collected");

            Invoke("NextScene", 5);
        }
    }

    void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Instruction");
    }

}