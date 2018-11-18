using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMainNextScene : MonoBehaviour {

    public void goToNextScene(int NextSceneIndex)
    {
        SceneManager.LoadScene(NextSceneIndex);
    }
}
