using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoaderToLevel1 : MonoBehaviour
{
    // Assign your button in the inspector or via script
    public Button yourButton;

    private void Start()
    {
        // Ensure the button is assigned and add a listener to it
        if (yourButton != null)
        {
            yourButton.onClick.AddListener(LoadLevel1Scene);
        }
    }

    // Function to load the scene named "level1"
    public void LoadLevel1Scene()
    {
        // Load the scene with the name "level1"
        SceneManager.LoadScene("level1");
    }
}
