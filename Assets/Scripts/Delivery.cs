using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32 (1, 1, 1, 1);

    SpriteRenderer spriteRenderer;

    [SerializeField] float destroyDelay = 0.1f;
    bool hasPackage;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Collision !!!");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        //Debug.Log("Collition Trigger !!!");
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package Pick UP !!!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Delivered Package !!!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }

    }
}
