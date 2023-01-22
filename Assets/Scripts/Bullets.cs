using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{

    public float speed = 70f;
    public float explosionRadius = 0f;
    public int damage = 50;
    public GameObject impactEffect;

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider && collision.collider.tag != "Player" && collision.collider.tag != "Bullet")
        {
            GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(effectIns, 3f);

            Destroy(gameObject);
        }
    }
}
