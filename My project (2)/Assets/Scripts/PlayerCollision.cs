using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public GameObject heldItem;
    public string heldItemName;

    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collectable")
        {
            
           // heldItem.transform.localScale = new Vector3(16, 2, 16);

           // Destroy(collision.gameObject);
        }
    }
}
    