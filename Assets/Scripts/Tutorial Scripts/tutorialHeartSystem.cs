using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class tutorialHeartSystem : MonoBehaviour
{
    public GameObject[] heartss;
    private int lives;
    public static int num_heartss = 9;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (num_heartss < 1)
        {
            Destroy(heartss[0].gameObject);
        }
        if (num_heartss < 2)
        {
            Destroy(heartss[1].gameObject);
        }
        if (num_heartss < 3)
        {
            Destroy(heartss[2].gameObject);
        }
        if (num_heartss < 4)
        {
            Destroy(heartss[3].gameObject);
        }
        if (num_heartss < 5)
        {
            Destroy(heartss[4].gameObject);
        }
        if (num_heartss < 6)
        {
            Destroy(heartss[5].gameObject);
        }
        if (num_heartss < 7)
        {
            Destroy(heartss[6].gameObject);
        }
        if (num_heartss < 8)
        {
            Destroy(heartss[7].gameObject);
        }
        if (num_heartss < 9)
        {
            Destroy(heartss[8].gameObject);
        }
    }

    public void TakeDamage(int damages) {
        lives -= damages;
    }

    
}
