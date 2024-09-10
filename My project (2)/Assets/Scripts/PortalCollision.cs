using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalCollision : MonoBehaviour
{

    //public int keyCount;

    // Start is called before the first frame update
    void Start()
    {
        //keyCount = GameObject.FindGameObjectsWithTag("Key").Length;
    }

     //Update is called once per frame
    void Update()
    {
        //keyCount = GameObject.FindGameObjectsWithTag("Key").Length;
    }




    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Player touched");
        if (collision.gameObject.tag == "Player")
        {
            print("SceneChange");
            SceneManager.LoadScene(1);
        }
    }
}
