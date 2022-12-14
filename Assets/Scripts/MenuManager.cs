using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PlayGame(){

        StartCoroutine(LoadNextSceneAfterDelay(1.15f));

    }

    public void ChooseScene(string sceneName)
    {
        StartCoroutine(LoadSceneAfterDelay(1.15f, sceneName));
    }

    public void QuitGame(){
        Application.Quit();
    }


    IEnumerator LoadNextSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator LoadSceneAfterDelay(float delay, string sceneName)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}
