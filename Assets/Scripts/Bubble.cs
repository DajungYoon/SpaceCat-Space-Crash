using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    private float amplitude = 0.5f;
    public OxygenSystem oxg;
    public float extraHeight = 0;

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        SpaceCat cat = collision.gameObject.GetComponent<SpaceCat>();

        // if the cat is touching the bubble 
        if (cat != null) 
        {
            // the bubble will disappear
            gameObject.SetActive(false); 

            // the health bar will also recharge
            oxg.oxygen.SetMaxOxygen(oxg.oxygenLevel);
        }
    }

    void Update()
    {

        // bubbles float up and down
        float x = transform.position.x;
        float y = Mathf.Sin(Time.time) * amplitude + extraHeight;
        float z = transform.position.z;
        transform.position = new Vector3(x, y, z);
    }
}
