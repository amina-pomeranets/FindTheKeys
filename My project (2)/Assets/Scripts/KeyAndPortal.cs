using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyAndPortal : MonoBehaviour
{
    public GameObject key; // Reference to the key object
    public GameObject portal; // Reference to the portal object
    public string level2; // Name of the next level scene

    private bool hasKey = false;

    void Start()
    {
        portal.SetActive(false); // Hide the portal at the start
    }
    
    void Update()
    {
        if (hasKey && Input.GetKeyDown(KeyCode.E)) // Press 'E' to activate the portal
        {
            TeleportToNextLevel();
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == key)
        {
            hasKey = true;
            Destroy(key); // Collect the key
            portal.SetActive(true); // Show the portal
        }
        else if (other.gameObject == portal && hasKey)
        {
            TeleportToNextLevel();
        }
    }

    void TeleportToNextLevel()
    {
        SceneManager.LoadScene(1); // Load the next level
    }
}
