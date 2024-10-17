using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalCollisionLevel2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has the Swordman component
        Swordman swordman = collision.gameObject.GetComponent<Swordman>();

        if (swordman != null) // If the player has the Swordman component
        {
            if (swordman.keyCount >= 1) // Check if keyCount is 1 or more
            {
                Debug.Log("Teleporting to the next level!");
                TeleportToNextLevel2();
                swordman.AddKeyCount(-1); // Optionally reduce key count by 1
            }
            else
            {
                Debug.Log("Not enough keys to teleport.");
            }
        }
    }

    void TeleportToNextLevel2()
    {
        SceneManager.LoadScene(3); // Load the next level
    }
}


//public string sceneName;  // The name of the scene to switch to

//private void OnTriggerEnter(Collider other)
//{
//if (other.CompareTag("Player"))  // Check if the player enters the portal
//{
//SceneManager.LoadScene(sceneName);  // Load the specified scene
//}
//}
//}

//public int keyCount;

//public GameObject Portal;

//public Boolean holdingKey = false;

// Start is called before the first frame update
//void Start()
//{
//keyCount = GameObject.FindGameObjectsWithTag("Key").Length;

//Portal.SetActive(false);
//holdingKey = false;
//}

//Update is called once per frame
//void Update ()
//{
//keyCount = GameObject.FindGameObjectsWithTag("Key").Length;
//Portal.SetActive(true);

//if (holdingKey)
//{
//Portal.SetActive(true);
//}
//}



/*
    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Player touched");
        if (collision.gameObject.tag == "Key")
        {
            //Portal.SetActive(true);
            //holdingKey = true;

            print("SceneChange");
            SceneManager.LoadScene(1);
        }
    }


*/