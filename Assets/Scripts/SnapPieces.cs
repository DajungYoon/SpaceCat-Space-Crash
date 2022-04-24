using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnapPieces : MonoBehaviour
{

    private Vector3 rightPos;
    public bool inRightPos;
    public bool selected;
    public static int numPiecesInPos = 0;
  
    public float xPos;
    public float yPos;


    // Start is called before the first frame update
    void Start()
    {

        numPiecesInPos = 0;
        rightPos = transform.position;
        transform.position = new Vector3(xPos, yPos);
        

    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(transform.position, rightPos) < 0.5f)
        {
    
            transform.position = rightPos;
            inRightPos = true;
        }
    }
}
