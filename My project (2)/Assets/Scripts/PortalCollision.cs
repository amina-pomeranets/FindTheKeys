using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalCollision : MonoBehaviour
{
    public string sceneName;  // The name of the scene to switch to

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // Check if the player enters the portal
        {
            SceneManager.LoadScene(sceneName);  // Load the specified scene
        }
    }
}

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
//}
