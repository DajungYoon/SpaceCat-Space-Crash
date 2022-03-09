using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Transform playerTransform;
    public float offset;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;


    }

    void LateUpdate()
    {
        // store current cam pos    
        Vector3 temp = transform.position;

        // set cam's pos x equal to player's pos
        temp.x = playerTransform.position.x;
        temp.y = playerTransform.position.y;

        temp.y += offset;

        // set tem pos back to cam current pos
        transform.position = temp;
    }

    // Update is called once per frame
    void Update()
    {
    }
        
}
