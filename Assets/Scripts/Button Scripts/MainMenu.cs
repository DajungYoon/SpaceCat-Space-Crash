using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //this function will load in the next scene availble
    public void PlayGame(){
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("space_cat");
    }

    public void QuitGame (){
        //this will let us know that the program is closing
        //only in unity
        Debug.Log("Quit");
        Application.Quit();
    }

     public void Tutorial(){
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("Tutorial");
    }
}
