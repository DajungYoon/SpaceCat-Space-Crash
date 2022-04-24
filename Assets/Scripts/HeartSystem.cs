using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] hearts;
    private int life;
    public static int num_hearts = 9;

    // Start is called before the first frame update
    void Start()
    {
        num_hearts = 9;
    }

    // Update is called once per frame
    void Update()
    {
        if (num_hearts < 1)
        {
            SceneManager.LoadScene("EndGame");
            Destroy(hearts[0].gameObject);
        }
        if (num_hearts < 2)
        {
            Destroy(hearts[1].gameObject);
        }
        if (num_hearts < 3)
        {
            Destroy(hearts[2].gameObject);
        }
        if (num_hearts < 4)
        {
            Destroy(hearts[3].gameObject);
        }
        if (num_hearts < 5)
        {
            Destroy(hearts[4].gameObject);
        }
        if (num_hearts < 6)
        {
            Destroy(hearts[5].gameObject);
        }
        if (num_hearts < 7)
        {
            Destroy(hearts[6].gameObject);
        }
        if (num_hearts < 8)
        {
            Destroy(hearts[7].gameObject);
        }
        if (num_hearts < 9)
        {
            Destroy(hearts[8].gameObject);
        }
    }

    public void TakeDamage(int damage) {
        life -= damage;
    }

    
}
