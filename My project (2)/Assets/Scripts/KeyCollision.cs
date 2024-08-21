using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollision : MonoBehaviour
{
    public GameObject player;

    public Boolean following;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        following = true;
        player = collision.gameObject;
    }

    private void FollowPlayer()
    {
        if (following)
        {
            Vector3 playerPosition = player.transform.position;

            transform.position = playerPosition;
        }
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }
}
