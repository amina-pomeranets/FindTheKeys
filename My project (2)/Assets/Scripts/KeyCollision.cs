/*

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KeyCollision : MonoBehaviour
{
    public GameObject player;
    public GameObject Key;
    public GameObject portal;
    //public Text keyText;


    //public GameObject key;
    public Boolean following;
    public Boolean holdingKey = false;




    private bool hasKey = false;

    // Start is called before the first frame update
    void Start()
    {
        //keyText.text = "Keys: 0";
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        following = true;

        if (collision.gameObject == Key)
        {
            print("TouchingKey");

            hasKey = true;
            //Destroy(Key); // Collect the key
            portal.SetActive(true); // Show the portal
            //keyText.text = "Keys: 1";
        }
        else if (collision.gameObject == portal && hasKey)
        {
            TeleportToNextLevel();
        }
    }










    void TeleportToNextLevel()
    {
        SceneManager.LoadScene(1); // Load the next level
    }

    private void FollowPlayer()
    {

        if (following)
        {
            Vector3 keyOffset = new Vector3(0, 0, 0);

            if (player.transform.localScale.x == -1)
            {
                keyOffset = player.transform.position + new Vector3(1.5f, 0, 0);
                transform.rotation = new Quaternion(0, 0, 0, 0);

            }
            else if (player.transform.localScale.y == 1)
            {
                keyOffset = player.transform.position + new Vector3(-1.5f, 0, 0);
                transform.rotation = new Quaternion(0, 180, 0, 0);
            }
            transform.position = keyOffset;
        }
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }
}

*/










using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyCollision : MonoBehaviour
{
    public GameObject player;
    //public GameObject key;

    public Boolean following;

    //public Boolean holdingKey = false;

    //public int keyCount = 1;

    //public Text keyText;

    //public GameObject keyObject;

    //public Text text;

    //public Text keyMessageText;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        following = true;

        // Check if the collided object has the Swordman component
        Swordman swordman = collision.gameObject.GetComponent<Swordman>();

        if (swordman != null) // If the player has the Swordman component
        {
            swordman.AddKeyCount(1);
            Debug.Log("Key Count: " + swordman.keyCount); // Print the key count




            //keyMessageText.gameObject.SetActive(true); // Show the message
            //keyMessageText.text = "Now Find The Portal"; // Set the message text





            //~~~~~MAKE A MESSAGE FOR THE PLAYER TO FIND THE PORTAL, AFTER COLLECTING THE KEY~~~~~





            /*
                        using System.Collections;
                        using System.Collections.Generic;
                        using UnityEngine;
                        using UnityEngine.UI; // Make sure to include this for UI elements

            public class KeyCollision : MonoBehaviour
                {
                    public GameObject player;
                    public Text keyMessageText; // Reference to the UI Text
                    public float messageDisplayTime = 2f; // Time to display the message

                    private void OnCollisionEnter2D(Collision2D collision)
                    {
                        // Check if the collided object has the Swordman component
                        Swordman swordman = collision.gameObject.GetComponent<Swordman>();

                        if (swordman != null) // If the player has the Swordman component
                        {
                            swordman.AddKeyCount(1); // Add key
                            Debug.Log("Key Count: " + swordman.keyCount);
                            ShowKeyMessage(); // Call the function to show the message
                        }
                    }

                    private void ShowKeyMessage()
                    {
                        keyMessageText.gameObject.SetActive(true); // Show the message
                        keyMessageText.text = "Key Collected!"; // Set the message text
                        StartCoroutine(HideMessageAfterDelay()); // Start coroutine to hide it
                    }

                    private IEnumerator HideMessageAfterDelay()
                    {
                        yield return new WaitForSeconds(messageDisplayTime); // Wait for the specified time
                        keyMessageText.gameObject.SetActive(false); // Hide the message
                    }

                    private void FollowPlayer()
                    {
                        // Your existing FollowPlayer code here
                    }

                    void Update()
                    {
                        FollowPlayer();
                    }
                }
            */














        }

        //key = collision.gameObject;
        //collision.collider.isTrigger = true;

        //holdingKey = true;
        //keyPoints = 0;

        //if (collision.gameObject.tag == "Key")
        //{
        //keyCount -= 1;
        //keyText.text = keyCount.ToString();
        //}
    }

    private void FollowPlayer()
    {

        if (following)
        {
            Vector3 keyOffset = new Vector3(0, 0, 0);

            if (player.transform.localScale.x == -1)
            {
                keyOffset = player.transform.position + new Vector3(1.5f, 0, 0);
                transform.rotation = new Quaternion(0, 0, 0, 0);

            } else if (player.transform.localScale.y == 1)
            {
                keyOffset = player.transform.position + new Vector3(-1.5f, 0, 0);
                transform.rotation = new Quaternion(0, 180, 0, 0);
            }
            transform.position = keyOffset;
        }
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }
}

