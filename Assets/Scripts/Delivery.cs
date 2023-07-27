using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Collision !!!");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        //Debug.Log("Collition Trigger !!!");
        if (other.tag == "Package")
        {
            Debug.Log("Package Pick UP !!!");
            //Destroy();
        }

        if (other.tag == "Customer")
        {
            Debug.Log("Delivered Package !!!");
            //Destroy();
        }

    }
}
