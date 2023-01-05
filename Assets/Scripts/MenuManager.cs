using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
    public void PlayGame(){
        //loads in the game scene
        SceneManager.LoadScene(2);
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void NextScene(){
        //loads in the next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
