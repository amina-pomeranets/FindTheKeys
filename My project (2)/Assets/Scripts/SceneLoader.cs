using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    // Assign your button in the inspector or via script
    public Button yourButton;

    private void Start()
    {
        // Ensure the button is assigned and add a listener to it
        if (yourButton != null)
        {
            yourButton.onClick.AddListener(LoadNextScene);
        }
    }

    // Function to load the next scene based on the build index
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        // Check if the next scene index is within the valid range
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.LogWarning("No more scenes to load.");
        }
    }
}
