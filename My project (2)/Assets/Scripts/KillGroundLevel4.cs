using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillGroundLevel4 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Kill")
        {
            //transform.position = new Vector3 (-6.36f, 0.22f, 13.65f);
        }
        collision.gameObject.transform.position = new Vector3(31.2f, 0.27f, 13.65f);
    }

    //void React()
    //{
        //transform.position = new Vector3(-6.36f, 0.22f, 13.65f);
    //}
}
