using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneGuy : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void ChangeScene(string sceneName)
    {
        Scene scene = SceneManager.GetSceneByName(sceneName);
        //if (scene.IsValid())
        //{
            // The scene exists, so we can load it
            SceneManager.LoadScene(sceneName);
        //}
        //else
        //{
            // The scene does not exist
            //Debug.LogError("Scene not found: " + sceneName);
        //}
    }
}
