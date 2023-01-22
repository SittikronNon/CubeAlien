using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public bool isHolding = false;
    public float fireRate = 0.1f;

    private float nextFire = 0.0f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            isHolding = true;
        } 
        else
        {
            isHolding = false;
        }

        if(isHolding && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            ShootBullet();
        }

    }

    public void ShootBullet()
    {
        if(isHolding)
        {
            GameObject bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed; 
            /*
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * bulletSpeed, ForceMode.VelocityChange);
            */
        }
    }


    
}
