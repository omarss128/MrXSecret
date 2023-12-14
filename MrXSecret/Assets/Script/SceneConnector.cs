using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneConnector : MonoBehaviour
{
    public string nextSceneName; // The name of the next scene to load

    public void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
