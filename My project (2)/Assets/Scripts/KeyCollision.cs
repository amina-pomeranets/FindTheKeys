using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollision : MonoBehaviour
{
    public GameObject player;

    public Boolean following;

    //public Key holdingKey;
    //public GameObject keyObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        following = true;
        player = collision.gameObject;
        //collision.collider.isTrigger = true;

       
        
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
